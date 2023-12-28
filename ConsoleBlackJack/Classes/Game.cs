using ConsoleBlackJack.Classes.Cards;
using ConsoleBlackJack.Classes.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack.Classes
{
    internal class Game
    {
        private HumanPlayer _humanPlayer;
        private Croupier _croupier;
        private Deck _deck;
        public Game()
        {
            Console.OutputEncoding = Encoding.UTF8;

            _humanPlayer = new HumanPlayer("Hrac", _deck.GetCard(), _deck.GetCard());
            _croupier = new Croupier("Krupier", _deck.GetCard(), _deck.GetCard());

            do
            {
                _deck = new Deck();

                _humanPlayer.ViewAmmountCoins();
                _humanPlayer.MakeBet();

                while (_croupier.CanDrawCard())
                {
                    _croupier.DrawCard(_deck.GetCard());
                }

                _croupier.ShowFirstCard();

                _humanPlayer.ShowCards();

                while (_humanPlayer.CanDrawCard())
                {
                    _humanPlayer.DrawCard(_deck.GetCard());
                    _humanPlayer.ShowCards();
                }

                GameResult(_croupier.GetHand(), _humanPlayer.GetHand());

                Console.WriteLine("Do you want to play next game? [Y/N]");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "n")
                {
                    break;
                }
            } while (true);
        }

        private void GameResult(Hand croupierHand, Hand playerHand)
        {
            int playerSum = playerHand.CountValues();
            int croupierSum = croupierHand.CountValues();

            Console.WriteLine("Croupier's cards: " + croupierHand.GetAllCards());

            if (playerSum > 21)
            {
                Console.WriteLine("The croupier won");
            }
            else if (croupierSum > 21 && playerSum <= 21)
            {
                Console.WriteLine("You won");
                _humanPlayer.AddCoins();
            }
            else if (croupierSum <= 21 && playerSum <= 21)
            {
                if (croupierSum < playerSum)
                {
                    Console.WriteLine("You won");
                    _humanPlayer.AddCoins();
                }
                else if (croupierSum > playerSum)
                {
                    Console.WriteLine("The croupier won");
                }
                else
                {
                    Console.WriteLine("It's draw");
                    _humanPlayer.ReturnBet();
                }
            }
        }
    }
}

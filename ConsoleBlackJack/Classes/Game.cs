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

            int coins = 5000;

            do
            {
                Deck _deck = new Deck();
                HumanPlayer _humanPlayer = new HumanPlayer("Player", _deck.GetCard(), _deck.GetCard(), coins);
                Croupier _croupier = new Croupier("Croupier", _deck.GetCard(), _deck.GetCard());

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

                GameResult(_croupier, _humanPlayer);

                coins = _humanPlayer.GetCoins();

                Console.WriteLine("Do you want to play next game? [Y/N]");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "n")
                {
                    break;
                }

                Console.Clear();
            } while (true);
        }

        private void GameResult(Croupier croupier, HumanPlayer humanPlayer)
        {
            int croupierSum = croupier.GetHand().CountValues();
            int playerSum = humanPlayer.GetHand().CountValues();

            Console.WriteLine("Croupier's cards: " + croupier.GetHand().GetAllCards());

            if (playerSum > 21)
            {
                Console.WriteLine("The croupier won");
            }
            else if (croupierSum > 21 && playerSum <= 21)
            {
                Console.WriteLine("You won");
                humanPlayer.AddCoins();
            }
            else if (croupierSum <= 21 && playerSum <= 21)
            {
                if (croupierSum < playerSum)
                {
                    Console.WriteLine("You won");
                    humanPlayer.AddCoins();
                }
                else if (croupierSum > playerSum)
                {
                    Console.WriteLine("The croupier won");
                }
                else
                {
                    Console.WriteLine("It's draw");
                    humanPlayer.ReturnBet();
                }
            }
        }
    }
}

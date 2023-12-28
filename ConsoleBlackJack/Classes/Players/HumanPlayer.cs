using ConsoleBlackJack.Classes.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleBlackJack.Classes.Players
{
    internal class HumanPlayer : Player
    {
        private int _coins;
        public HumanPlayer(string name, Card cardOne, Card cardTwo)
        {
            _name = name;
            _hand = new Hand(cardOne, cardTwo);
            _coins = 5000;
        }

        public void GetCoins()
        {
            Console.WriteLine("You have " + _coins + " coins");
        }

        public int MakeBet()
        {
            Console.WriteLine("How many coins do you want to bet?");
            int bet = Int32.Parse(Console.ReadLine());
            while (true)
            {
                if (bet > _coins)
                {
                    Console.WriteLine("You don't have this ammount of coins");
                }
                else
                {
                    break;
                }
            }
            _coins -= bet;
            return bet;
        }

        public void AddCoins(int coinsToAdd)
        {
            _coins += coinsToAdd;
        }

        public override bool CanDrawCard()
        {
            if (_hand.CountValues() > 21)
            {
                return false;
            }
            while (true)
            {
                Console.WriteLine("Chces si liznout jeste kartu? [A/N]");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "a")
                {
                    return true;
                }
                else if (answer.ToLower() == "n")
                {
                    return false;
                }
            }
        }
    }
}

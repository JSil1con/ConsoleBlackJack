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
        private int _bet;
        public HumanPlayer(string name, Card cardOne, Card cardTwo, int coins)
        {
            _name = name;
            _hand = new Hand(cardOne, cardTwo);
            _coins = coins;
            _bet = 0;
        }

        public void ViewAmmountCoins()
        {
            Console.WriteLine("You have " + _coins + " coins");
        }

        public int MakeBet()
        {
            while (true)
            {
                Console.WriteLine("How many coins do you want to bet?");
                _bet = Int32.Parse(Console.ReadLine());
                if (_bet > _coins)
                {
                    Console.WriteLine("You don't have this ammount of coins");
                }
                else
                {
                    break;
                }
            }
            _coins -= _bet;
            return _bet;
        }

        public int GetCoins()
        {
            return _coins;
        }

        public void IncreaseBet()
        {
            _bet *= 2;
        }

        public void AddCoins()
        {
            _coins += _bet * 2;
        }

        public void ReturnBet()
        {
            _coins += _bet;
        }

        public override bool CanDrawCard()
        {
            if (_hand.CountValues() > 21)
            {
                return false;
            }
            while (true)
            {
                Console.WriteLine("Do you want to draw another card? [Y/N]");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
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

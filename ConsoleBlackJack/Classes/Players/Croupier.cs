using ConsoleBlackJack.Classes.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack.Classes.Players
{
    internal class Croupier : Player
    {
        public Croupier(string name, Card cardOne, Card cardTwo)
        {
            _name = name;
            _hand = new Hand(cardOne, cardTwo);
        }

        public void ShowFirstCard()
        {
            Console.WriteLine("Prvni karta krupiera je: " + _hand.GetCards()[0].GetCardInfo());
        }

        public override bool CanDrawCard()
        {
            if (_hand.CountValues() < 17)
            {
                return true;
            }
            return false;
        }
    }
}

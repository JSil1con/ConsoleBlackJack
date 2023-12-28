using ConsoleBlackJack.Classes.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleBlackJack.Classes.Players
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name, Card cardOne, Card cardTwo)
        {
            _name = name;
            _hand = new Hand(cardOne, cardTwo);
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

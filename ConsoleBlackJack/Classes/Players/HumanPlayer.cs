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
    }
}

using ConsoleBlackJack.Classes.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack.Classes.Players
{
    abstract class Player
    {
        protected string _name;
        protected Hand _hand;

        public abstract bool CanDrawCard();

        public void DrawCard(Card card)
        {
            _hand.SaveCard(card);
        }

        public void ShowCards()
        {
            Console.WriteLine(_name + "'s cards: " + _hand.GetAllCards());
        }

        public Hand GetHand() { return _hand; }
    }
}

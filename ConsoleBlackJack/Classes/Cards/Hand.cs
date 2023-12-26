using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack.Classes.Cards
{
    internal class Hand
    {
        private readonly List<Card> _cards = new List<Card>();
        public Hand(Card cardOne, Card cardTwo)
        {
            SaveCard(cardOne);
            SaveCard(cardTwo);
        }

        public void SaveCard(Card card)
        {
            _cards.Add(card);
        }

        public void ViewAllCards()
        {
            foreach (Card card in _cards)
            {
                Console.WriteLine(card.GetValue() + card.GetSymbol());
            }
        }
    }
}

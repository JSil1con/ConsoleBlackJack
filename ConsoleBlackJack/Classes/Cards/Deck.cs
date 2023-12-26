using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack.Classes.Cards
{
    internal class Deck
    {
        private readonly List<Card> _cards = new List<Card>();
        private string[] _symbols;
        private int[] _values;
        private Random _random = new Random();

        public Deck()
        {
            _symbols = new string[4] { "♦", "♥", "♠", "♣" };
            _values = new int[9] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (string symbol in _symbols)
            {
                foreach (int value in _values)
                {
                    _cards.Add(new Card(symbol, value));
                }
            }
        }

        public Card GetCard()
        {
            Card randomCard = _cards[_random.Next(_cards.Count)];
            _cards.Remove(randomCard);
            return randomCard;
        }
    }
}

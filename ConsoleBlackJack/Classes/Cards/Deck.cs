using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack.Classes.Cards
{
    internal class Deck
    {
        private readonly List<Card> _cards = new List<Card>();
        private string[] _symbols;
        private string[] _characters;
        private string[] _values;
        private Random _random = new Random();

        public Deck()
        {
            _symbols = new string[4] { "♠", "♣", "♥", "♦" };
            _values = new string[9] { "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            _characters = new string[4] { "J", "Q", "K", "A" };
            foreach (string symbol in _symbols)
            {
                foreach (string value in _values)
                {
                    _cards.Add(new Card(symbol, value));
                }
            }
            foreach (string symbol in _symbols)
            {
                foreach (string character in _characters)
                {
                    _cards.Add(new Card(symbol, character));
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

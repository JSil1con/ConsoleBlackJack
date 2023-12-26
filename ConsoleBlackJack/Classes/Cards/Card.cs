using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack.Classes.Cards
{
    internal class Card
    {
        private readonly string _symbol;
        private readonly int _value;
        public Card(string symbol, int value)
        {
            _symbol = symbol;
            _value = value;
        }

        public string GetSymbol()
        {
            return _symbol;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}

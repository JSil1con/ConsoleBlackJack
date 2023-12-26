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
        private readonly string _value;
        public Card(string symbol, string value)
        {
            _symbol = symbol;
            _value = value;
        }

        public string GetCardInfo()
        {
            return _value + "" + _symbol;
        }

        public string GetSymbol()
        {
            return _symbol;
        }

        public string GetValue()
        {
            return _value;
        }
    }
}

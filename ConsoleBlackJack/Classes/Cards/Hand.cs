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
        private int _sumCards;
        public Hand(Card cardOne, Card cardTwo)
        {
            SaveCard(cardOne);
            SaveCard(cardTwo);
            _sumCards = CountValues();
        }

        public void SaveCard(Card card)
        {
            _cards.Add(card);
        }

        public List<Card> GetCards()
        {
            return _cards;
        }

        public string GetAllCards()
        {
            string result = "";
            foreach (Card card in _cards)
            {
                result += card.GetCardInfo() + " ";
            }
            return result;
        }

        public int CountValues()
        {
            int sum = 0;
            int aceCount = 0;
            foreach (Card card in _cards)
            {
                if (card.GetValue() == "J" ||  card.GetValue() == "Q" || card.GetValue() == "K")
                {
                    sum += 10;
                }
                else if(card.GetValue() == "A")
                {
                    sum += 11;
                    aceCount++;
                }
                else
                {
                    sum+= Int32.Parse(card.GetValue());
                }

            }

            while (sum > 21 && aceCount > 0)
            {
                sum -= 10;
                aceCount--;
            }
            return sum;
        }
    }
}

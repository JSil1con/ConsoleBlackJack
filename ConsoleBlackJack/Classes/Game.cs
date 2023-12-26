using ConsoleBlackJack.Classes.Cards;
using ConsoleBlackJack.Classes.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackJack.Classes
{
    internal class Game
    {
        private HumanPlayer _humanPlayer;
        private Croupier _croupier;
        private Deck _deck;
        public Game()
        {
            _deck = new Deck();
            _humanPlayer = new HumanPlayer("Hrac", _deck.GetCard(), _deck.GetCard());
            _croupier = new Croupier("Krupier", _deck.GetCard(), _deck.GetCard());
        }
    }
}

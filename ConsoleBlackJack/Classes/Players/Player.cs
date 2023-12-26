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
    }
}

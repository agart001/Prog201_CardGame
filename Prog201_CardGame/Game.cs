using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog201_CardGame
{
    internal class Game
    {
        public Deck Deck = new Deck();

        public string Name { get; set; }
        public string Desc { get; set; }

        public int NumDecks { get; set; }
        public double HouseMoney { get; set; }
        public int HandSize { get; set; }

        public Game(string _Name, string _Desc, int _NumDecks, double _HouseMoney, int _HandSize)
        {
            Name = _Name;
            Desc = _Desc;
            NumDecks = _NumDecks;
            HouseMoney = _HouseMoney;
            HandSize = _HandSize;
        }
    }
}

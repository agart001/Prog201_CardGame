using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog201_CardGame
{
    internal class AnO : Game
    {
        public AnO
        (string _Name, string _Desc, string[] _Suites, int _NumDecks, double _HouseMoney, int _HandSize) : 
        base(_Name, _Desc, _Suites, _NumDecks, _HouseMoney, _HandSize)
        {
        }

        public override void Loop()
        {
            
            Dealer.PrintDeck();
        }
    }
}

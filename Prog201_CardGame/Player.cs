using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog201_CardGame
{
    internal class Player
    {
        public string Name { get; set; }

        public List<Card> Hand = new List<Card>();

        public double Money { get; set; }

    }
}

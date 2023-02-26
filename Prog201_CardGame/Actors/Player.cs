using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog201_CardGame.Utility;
using Prog201_CardGame.Frames;

namespace Prog201_CardGame.Actors
{
    internal class Player
    {
        public string Name { get; set; }

        public List<Card> Hand = new List<Card>();

        public double Money { get; set; }

        public Player()
        {

        }

        public void ShowHand()
        {
            int i = 0;
            Print("Player's Hand: ");
            SpaceLine();
            foreach (Card card in Hand)
            {
                i++;
                Print(i + ": " + card.Image);
            }
            SpaceLine();
        }

    }
}

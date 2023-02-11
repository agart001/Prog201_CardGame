using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
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
            Print("Player Hand: ");
            SpaceLine();
            foreach (Card card in Hand)
            {
                Print(card.Image);
            }
            SpaceLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal class Dealer
    {
        Deck gen;
        public List<List<Card>> Decks = new List<List<Card>>();

        public int NumDecks { get; set; }

        public List<Card> Hand = new List<Card>();

        int HandSize { get; set; }

        public double Money { get; set; }

        public Dealer( Game _game) 
        {
            HandSize = _game.HandSize;

            gen = _game.Deck;

            NumDecks = _game.NumDecks;

            Decks = gen.CreateDecks(NumDecks);
        }

        public void PrintDeck()
        {
            foreach (List<Card> _deck in Decks)
            {
                foreach (Card card in _deck)
                {
                    Print(card.Image);
                }
                Print("-----------------");
            }
        }

        public void Shuffle()
        {
            foreach(List<Card> _deck in Decks) 
            {
                foreach( Card card in _deck.ToList())
                {
                    int n = _deck.Count;
                    while (n > 1)
                    {
                        n--;
                        int k = Rand.Next(n + 1);
                        Card _card = _deck[k];
                        _deck[k] = _deck[n];
                        _deck[n] = _card;
                    }

                }
            }
        }

        public void Deal(List<Card> PlayerHand)
        {
            for(int i = 0; i < HandSize; i++)
            {
                gen.DrawCard(Decks, Hand);
            }

            for (int i = 0; i < HandSize; i++)
            {
                gen.DrawCard(Decks, PlayerHand);
            }
        }


    }
}

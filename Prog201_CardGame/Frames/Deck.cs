using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog201_CardGame.Utility;

namespace Prog201_CardGame.Frames
{
    internal class Deck
    {
        public string[] Suites;

        public Deck(string[] _Suites) { Suites = _Suites; }

        void AddCard( List<Card> _Deck ,string _Suite, int _Number, string _Face, string _Image)
        {
            Card Card = new Card
            {
                Suite= _Suite,
                Number= _Number,
                Face= _Face,
                Image= _Image
            };
            _Deck.Add(Card);
        }

        List<Card> CreateDeck() 
        {
            List<Card> Deck = new List<Card>();

            foreach(string suite in Suites)
            {
                for (int i = 1; i <= 13; i++)
                {
                    if (i != 1 && i != 11 && i != 12 && i != 13)
                    {
                        AddCard(Deck, suite, i, "none", $"{i} of {suite}");
                    }
                    else if (i == 1)
                    {
                        AddCard(Deck, suite, i, "Ace", $"Ace of {suite}");
                    }
                    else if (i == 11)
                    {
                        AddCard(Deck, suite, i, "Jack", $"Jack of {suite}");
                    }
                    else if (i == 12)
                    {
                        AddCard(Deck, suite, i, "Queen", $"Queen of {suite}");
                    }
                    else if (i == 13)
                    {
                        AddCard(Deck, suite, i, "King", $"King of {suite}");
                    }
                }
            }

            return Deck;
        }

        public List<List<Card>> CreateDecks(int amount)
        {
            List<List<Card>> Decks = new List<List<Card>>();

            for (int i = 0; i < amount; i++) 
            { 
                List<Card> _deck = new List<Card>();
                _deck = CreateDeck();
                Decks.Add(_deck);
            }
            return Decks;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog201_CardGame
{
    internal class Deck
    {

        public void AddCard( List<Card> _Deck ,string _Suite, int _Number, string _Face, string _Image)
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

        public List<Card> CreateDeck() 
        {
            List<Card> Deck = new List<Card>();
            #region Clubs
            for(int i = 1; i <= 13; i++)
            {
                if(i != 1 && i != 11 && i != 12 && i != 13)
                {
                    AddCard(Deck, "Clubs", i, "none", $"C-{i}" );
                }
                else if(i == 1)
                {
                    AddCard(Deck, "Clubs", i, "Ace", "C-A");
                }
                else if (i == 11)
                {
                    AddCard(Deck, "Clubs", i, "Jack", "C-J");
                }
                else if (i == 12)
                {
                    AddCard(Deck, "Clubs", i, "Queen", "C-Q");
                }
                else if (i == 13)
                {
                    AddCard(Deck, "Clubs", i, "King", "C-K");
                }
            }
            #endregion

            #region Diamonds
            for (int i = 1; i <= 13; i++)
            {
                if (i != 1 && i != 11 && i != 12 && i != 13)
                {
                    AddCard(Deck, "Diamonds", i, "none", $"D-{i}");
                }
                else if (i == 1)
                {
                    AddCard(Deck, "Diamonds", i, "Ace", "D-A");
                }
                else if (i == 11)
                {
                    AddCard(Deck, "Diamonds", i, "Jack", "D-J");
                }
                else if (i == 12)
                {
                    AddCard(Deck, "Diamonds", i, "Queen", "D-Q");
                }
                else if (i == 13)
                {
                    AddCard(Deck, "Diamonds", i, "King", "D-K");
                }
            }
            #endregion

            #region Hearts
            for (int i = 1; i <= 13; i++)
            {
                if (i != 1 && i != 11 && i != 12 && i != 13)
                {
                    AddCard(Deck, "Hearts", i, "none", $"H-{i}");
                }
                else if (i == 1)
                {
                    AddCard(Deck, "Hearts", i, "Ace", "H-A");
                }
                else if (i == 11)
                {
                    AddCard(Deck, "Hearts", i, "Jack", "H-J");
                }
                else if (i == 12)
                {
                    AddCard(Deck, "Hearts", i, "Queen", "H-Q");
                }
                else if (i == 13)
                {
                    AddCard(Deck, "Hearts", i, "King", "H-K");
                }
            }
            #endregion

            #region Spades
            for (int i = 1; i <= 13; i++)
            {
                if (i != 1 && i != 11 && i != 12 && i != 13)
                {
                    AddCard(Deck, "Spades", i, "none", $"S-{i}");
                }
                else if (i == 1)
                {
                    AddCard(Deck, "Spades", i, "Ace", "S-A");
                }
                else if (i == 11)
                {
                    AddCard(Deck, "Spades", i, "Jack", "S-J");
                }
                else if (i == 12)
                {
                    AddCard(Deck, "Spades", i, "Queen", "S-Q");
                }
                else if (i == 13)
                {
                    AddCard(Deck, "Spades", i, "King", "S-K");
                }
            }
            #endregion

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

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
            AddCard(Deck, "Clubs", 1, "Ace", "C-A");
            AddCard(Deck, "Clubs", 2, "none", "C-2");
            AddCard(Deck, "Clubs", 3, "none", "C-3");
            AddCard(Deck, "Clubs", 4, "none", "C-4");
            AddCard(Deck, "Clubs", 5, "none", "C-5");
            AddCard(Deck, "Clubs", 6, "none", "C-6");
            AddCard(Deck, "Clubs", 7, "none", "C-7");
            AddCard(Deck, "Clubs", 8, "none", "C-8");
            AddCard(Deck, "Clubs", 9, "none", "C-9");
            AddCard(Deck, "Clubs", 10, "none", "C-10");
            AddCard(Deck, "Clubs", 11, "Jack", "C-J");
            AddCard(Deck, "Clubs", 12, "Queen", "C-Q");
            AddCard(Deck, "Clubs", 13, "King", "C-K");
            #endregion

            #region Diamonds
            AddCard(Deck, "Diamonds", 1, "Ace", "D-A");
            AddCard(Deck, "Diamonds", 2, "none", "D-2");
            AddCard(Deck, "Diamonds", 3, "none", "D-3");
            AddCard(Deck, "Diamonds", 4, "none", "D-4");
            AddCard(Deck, "Diamonds", 5, "none", "D-5");
            AddCard(Deck, "Diamonds", 6, "none", "D-6");
            AddCard(Deck, "Diamonds", 7, "none", "D-7");
            AddCard(Deck, "Diamonds", 8, "none", "D-8");
            AddCard(Deck, "Diamonds", 9, "none", "D-9");
            AddCard(Deck, "Diamonds", 10, "none", "D-10");
            AddCard(Deck, "Diamonds", 11, "Jack", "D-J");
            AddCard(Deck, "Diamonds", 12, "Queen", "D-Q");
            AddCard(Deck, "Diamonds", 13, "King", "D-K");
            #endregion

            #region Hearts
            AddCard(Deck, "Hearts", 1, "Ace", "H-A");
            AddCard(Deck, "Hearts", 2, "none", "H-2");
            AddCard(Deck, "Hearts", 3, "none", "H-3");
            AddCard(Deck, "Hearts", 4, "none", "H-4");
            AddCard(Deck, "Hearts", 5, "none", "H-5");
            AddCard(Deck, "Hearts", 6, "none", "H-6");
            AddCard(Deck, "Hearts", 7, "none", "H-7");
            AddCard(Deck, "Hearts", 8, "none", "H-8");
            AddCard(Deck, "Hearts", 9, "none", "H-9");
            AddCard(Deck, "Hearts", 10, "none", "H-10");
            AddCard(Deck, "Hearts", 11, "Jack", "H-J");
            AddCard(Deck, "Hearts", 12, "Queen", "H-Q");
            AddCard(Deck, "Hearts", 13, "King", "H-K");
            #endregion

            #region Spades
            AddCard(Deck, "Spades", 1, "Ace", "S-A");
            AddCard(Deck, "Spades", 2, "none", "S-2");
            AddCard(Deck, "Spades", 3, "none", "S-3");
            AddCard(Deck, "Spades", 4, "none", "S-4");
            AddCard(Deck, "Spades", 5, "none", "S-5");
            AddCard(Deck, "Spades", 6, "none", "S-6");
            AddCard(Deck, "Spades", 7, "none", "S-7");
            AddCard(Deck, "Spades", 8, "none", "S-8");
            AddCard(Deck, "Spades", 9, "none", "S-9");
            AddCard(Deck, "Spades", 10, "none", "S-10");
            AddCard(Deck, "Spades", 11, "Jack", "S-J");
            AddCard(Deck, "Spades", 12, "Queen", "S-Q");
            AddCard(Deck, "Spades", 13, "King", "S-K");
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

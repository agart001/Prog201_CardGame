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
        List<List<Card>> Decks = new List<List<Card>>();

        public List<Card> Hand = new List<Card>();

        int HandSize { get; set; }

        public double Money { get; set; }

        public Dealer(List<List<Card>> _Decks, int _HandSize, double _Money) 
        {
            Decks = _Decks;
            HandSize = _HandSize;
            Money = _Money;
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

        public void ShowHand()
        {
            Print("Dealer Hand: ");
            SpaceLine();
            foreach (Card card in Hand)
            {
                Print(card.Image);
            }
            SpaceLine();
        }


        public void Shuffle()
        {
            foreach (List<Card> _Deck in Decks)
            {
                int n = _Deck.Count;
                while (n > 1)
                {
                    n--;
                    int k = Rand.Next(n + 1);
                    Card _Card = _Deck[k];
                    _Deck[k] = _Deck[n];
                    _Deck[n] = _Card;
                }
            }
        }

        public Card DrawCard()
        {
            List<Card> _Deck = Decks.Last();
            if (_Deck.Count > 0)
            {
                Card _Card = _Deck.Last();
                _Deck.Remove(_Card);
                return _Card;
            }
            else
            {
                return null;
            }
        }

        public void DiscardCard(int x, int y)
        {
            Hand.RemoveRange(x, y);
        }

        public void Deal(List<Card> _Hand, int _Amount)
        {
            for(int i = 0; i < _Amount; i++)
            {
                Card _Card = DrawCard();
                if (_Card != null) { _Hand.Add(_Card); }
            }
        }


    }
}

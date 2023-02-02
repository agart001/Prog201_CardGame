

namespace Prog201_CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck _deck = new Deck();
            List<Card> deck = _deck.CreateDeck();

            foreach (Card card in deck)
            {
                if (card.Face == "Ace")
                {
                    Console.WriteLine("--------");
                }
                Console.WriteLine(card.Image);
            }
        }
        
    }
}
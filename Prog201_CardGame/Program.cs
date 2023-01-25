

namespace Prog201_CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck dealer = new Deck();
            List<List<Card>> new_decks = new List<List<Card>>();
            new_decks = dealer.CreateDecks(2);

            int b = 5;

            foreach(List<Card> deck in new_decks)
            {
                Console.WriteLine("-----------");
                foreach (Card card in deck) 
                {
                    Console.WriteLine(card.Image);
                }
                Console.WriteLine("-----------");
            }
        }
        
    }
}
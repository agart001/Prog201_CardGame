using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal class Program
    {
        /*
         
         * Card Game Framework
         * Alex Gartner, 02/26/2023
         * Credits
         * - Shuffle Deck Function - Fisher-Yates Shuffle
   
         */

        static void Main(string[] args)
        {
            Engine _Eng = new Engine();
            _Eng.Menu();
        }
        
    }
}
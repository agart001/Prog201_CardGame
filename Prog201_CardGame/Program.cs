using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            AnO _An0 = new AnO
            (
                "Apples and Oranges",
                "A guessing game of Suites, guess one suite or the other",
                new string[] { "Apples", "Oranges" },
                1, 
                10000, 
                1
           );

           _An0.Start();
            */

            /*
            HoL _HoL = new HoL
            (
                "Higher or Lower",
                "A guessing game of Numbers, guess if the next card's number is higher or lower",
                new string[] {"Clubs", "Diamonds", "Hearts", "Spades"},
                1,
                10000,
                2
            );

            _HoL.Start();
            */

            HiM _HiM = new HiM
            (
                "Highest Match",
                "A numbers game, where like suites add to a player's total",
                new string[] {"CLubs", "Diamonds", "Hearts", "Spades"},
                1,
                100000,
                4
            );

            _HiM.Start();

        }
        
    }
}
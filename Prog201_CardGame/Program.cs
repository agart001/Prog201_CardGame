using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
        
    }
}
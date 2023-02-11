using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Game", "fun game", new string[] {"Apples","Oranges" }, 1, 100000, 3);
            game.Start();
        }
        
    }
}
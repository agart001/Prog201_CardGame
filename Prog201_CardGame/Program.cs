

namespace Prog201_CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Game", "fun game", 1, 100000, 3);

            Dealer dealer = new Dealer(game);

            Player player = new Player();

            dealer.Deal(player.Hand);


        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal class AnO : Game
    {
        public AnO
        (string _Name, string _Desc, string[] _Suites, int _NumDecks, double _HouseMoney, int _HandSize) : 
        base(_Name, _Desc, _Suites, _NumDecks, _HouseMoney, _HandSize)
        {
        }

        public override void Loop()
        {
            Dealer.Deal(Dealer.Hand, HandSize);
            SpaceLine();
            if(Question("Will the card be apples or oranges?", "apples", "oranges"))
            {
                SpaceLine();
                if (ConvertToLower(Dealer.Hand[0].Suite) == "apples")
                {
                    Print("Great Guess! You win!");
                    Player.Money += 10;
                }
                else
                {
                    Print("Bad Guess! You lose!");
                    Player.Money -= 10;
                }
            }
            else
            {
                SpaceLine();
                if (ConvertToLower(Dealer.Hand[0].Suite) == "oranges")
                {
                    Print("Great Guess! You win!");
                    Player.Money += 10;
                }
                else
                {
                    Print("Bad Guess! You lose!");
                    Player.Money -= 10;
                }
            }

            Dealer.ShowHand();
            Dealer.Hand.Clear();
            SpaceLine();

            if(Question("Wanna play again? (y/n)", "y", "n"))
            {
                Loop();
            }
            else
            {
                Stop();
            }
        }
    }
}

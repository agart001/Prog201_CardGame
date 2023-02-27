using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog201_CardGame.Frames;
using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal class AnO : Frames.Game
    {
        int Round = 0;
        public AnO
        (string _Name, string _Desc, string[] _Suites, int _NumDecks, double _HouseMoney, int _HandSize) : 
        base(_Name, _Desc, _Suites, _NumDecks, _HouseMoney, _HandSize)
        {
        }

        public override void Loop()
        {
            Dealer.Deal(Dealer.Hand, HandSize);
            SpaceLine();

            if(Round == 0) 
            {
                Print("The first card is: ");
                Print(Dealer.Hand[0].Image);
                SpaceLine();
                Dealer.Hand.Clear();
                Dealer.Deal(Dealer.Hand, HandSize);
            }

            Round++;
            GetChoice();

            SpaceLine();
            Print("The next card is: ");
            Print(Dealer.Hand[0].Image);
            SpaceLine();

            Dealer.Hand.Clear();

            ContinuePlay();

        }

        void ApplesChoice()
        {
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

        void OrangesChoice()
        {
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

        void GetChoice()
        {
            if (QuestionInt("Will the next card be apples or oranges? 1) apples or 2) oranges", 1, 2))
            {
                SpaceLine();
                ApplesChoice();
            }
            else
            {
                SpaceLine();
                OrangesChoice();
            }
        }
    }
}

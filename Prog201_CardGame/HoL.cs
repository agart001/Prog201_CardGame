using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal class HoL : Game
    {
        Card previousCard;
        Card nextCard;

        public HoL(string _Name, string _Desc, string[] _Suites, int _NumDecks, double _HouseMoney, int _HandSize) :
        base(_Name, _Desc, _Suites, _NumDecks, _HouseMoney, _HandSize)
        {
        }

        public override void Loop()
        {
            Dealer.Deal(Dealer.Hand, HandSize);
            SpaceLine();

            previousCard = Dealer.Hand[0];
            nextCard = Dealer.Hand[1];

            Print("The first card is: ");
            Print(previousCard.Image);
            SpaceLine();

            if (QuestionInt("Will the next card be higher or lower? 1) higher or 2) lower", 1, 2))
            {
                SpaceLine();
                if (nextCard.Number > previousCard.Number)
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
                if (nextCard.Number < previousCard.Number)
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

            SpaceLine();
            Print("The next card is: ");
            Print(nextCard.Image);

            Dealer.Hand.Clear();
            SpaceLine();

            if (Question("Wanna play again? (y/n)", "y", "n"))
            {
                DisplayClear();
                Loop();
            }
            else
            {
                Stop();
            }
        }
    }
}

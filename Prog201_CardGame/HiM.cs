using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal class HiM : Game
    {
        int Round = 0;
        public HiM(string _Name, string _Desc, string[] _Suites, int _NumDecks, double _HouseMoney, int _HandSize) : base(_Name, _Desc, _Suites, _NumDecks, _HouseMoney, _HandSize)
        {
        }

        public override void Loop()
        {
            Dealer.Deal(Player.Hand, HandSize);
            Dealer.Deal(Dealer.Hand, HandSize);

            SpaceLine();
            Print("The dealer has dealt you and themselves a hand");
            SpaceLine();

            Player.ShowHand();

            GameLoop();
        }

        void GameLoop()
        {
            if (Round == 10)
            {

            }
            else
            {
                Round++;

                if (Question("Would you like to remove a card? (y/n)", "y", "n"))
                {
                    Print("Would you like to remove a card and draw another? (index number)");
                    int index = InputInt();
                    Player.Hand.Remove(Player.Hand[index - 1]);
                    Dealer.Deal(Player.Hand, 1);
                    Player.ShowHand();
                }
                else
                {
                    GameLoop();
                }
            }
        }
    }
}

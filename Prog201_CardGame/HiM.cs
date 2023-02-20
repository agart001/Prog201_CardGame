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
        int MaxPointValue = 40;

        int PlayerTotal = 0;
        int DealerTotal = 0;
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

        string FavoredSuite(List<Card> _Hand)
        {
            int i = 0;
            int[] Weights = new int[4];
            foreach(string Suite in Suites) 
            {
                foreach(Card _Card in _Hand) 
                {
                    if(Suite == _Card.Suite) 
                    {
                        Weights[i] += 1;
                    }
                }
                i++;
            }

            int FavoredValue = Weights.Max();
            int FavoredIndex = Array.IndexOf(Weights, FavoredValue);

            return Suites[FavoredIndex];
        }

        int GetTotal(List<Card> _Hand)
        {
            int Total = 0;
            string Suite = FavoredSuite(_Hand);
            foreach(Card _Card in _Hand)
            {
                if(_Card.Suite == Suite)
                {
                    Total += 10;
                }
            }

            return Total;
        }

        void GetTotals()
        {
            PlayerTotal = GetTotal(Player.Hand);
            DealerTotal = GetTotal(Dealer.Hand);

            Print("Total: " + PlayerTotal);
            SpaceLine();
            Print("D Total: " + DealerTotal);
        }

        void PlayerDraw()
        {
            if (Question("Would you like to remove a card? (y/n)", "y", "n"))
            {
                Print("Would you like to remove a card and draw another? (index number)");
                int index = InputInt();
                Player.Hand.Remove(Player.Hand[index - 1]);
                Dealer.Deal(Player.Hand, 1);

                Player.ShowHand();
            }
        }

        void DealerDraw()
        {
            if(DealerTotal < MaxPointValue)
            {
                string Suite = FavoredSuite(Dealer.Hand);
                foreach (Card _Card in Dealer.Hand)
                {
                    if (!_Card.Suite.Contains(Suite))
                    {
                        Dealer.Hand.Remove(_Card);
                        Dealer.Deal(Dealer.Hand, 1);
                        break;
                    }
                }
            }
        }




        void GameLoop()
        {
            if (Round == 10)
            {

            }
            else
            {
                Round++;

                GetTotals();

                PlayerDraw();

                DealerDraw();

                GameLoop();
            }
        }
    }
}

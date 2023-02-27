using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog201_CardGame.Frames;
using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal class Engine
    {
        List<Game> Games = new List<Game>
        {
             new AnO
                (
                    "Apples and Oranges",
                    "A guessing game of Suites, guess one suite or the other",
                    new string[] { "Apples", "Oranges" },
                    1,
                    10000,
                    1
                ),
            new HoL
                (
                    "Higher or Lower",
                    "A guessing game of Numbers, guess if the next card's number is higher or lower",
                    new string[] {"Clubs", "Diamonds", "Hearts", "Spades"},
                    1,
                    10000,
                    2
                ),
           new HiM
                (
                    "Highest Match",
                    "A numbers game, where like suites add to a player's total",
                    new string[] {"CLubs", "Diamonds", "Hearts", "Spades"},
                    1,
                    100000,
                    4
                )
        };
        Game ChoosenGame;

        void PrintGames()
        {
            int index = 1;
            SpaceLine();
            foreach(Game Game in Games)
            {
                Print($"{index}: {Game.Name}");
                Print(Game.Desc);
                SpaceLine();
                index++;
            }
            Print("4: Exit");
            SpaceLine();
        }

        void GetGameChoice()
        {
            Print("What Game would you like to play? (enter an index)");
            SpaceLine();
            int index = InputInt();

            if(index>4||index<1)
            {
                SpaceLine();
                GetGameChoice();
            }
            else
            {
                if (index == 4)
                {
                    CloseApp();
                }
                else
                {
                    ChoosenGame = Games[index - 1];
                }
            }
        }

        public void Menu()
        {
            PrintGames();

            GetGameChoice();

            DisplayClear();

            ChoosenGame.Start();
        }
    }
}

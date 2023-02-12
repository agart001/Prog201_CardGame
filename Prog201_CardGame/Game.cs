﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog201_CardGame.Utility;

namespace Prog201_CardGame
{
    internal abstract class Game
    {
        public Deck Deck;
        List<List<Card>> Decks;

        public Player Player;
        public Dealer Dealer;

        public string Name { get; set; }
        public string Desc { get; set; }
        public string[] Suites { get; set; }

        public int NumDecks { get; set; }
        public double HouseMoney { get; set; }
        public int HandSize { get; set; }

        public Game(string _Name, string _Desc, string[] _Suites, int _NumDecks, double _HouseMoney, int _HandSize)
        {
            Name = _Name;
            Desc = _Desc;
            Suites = _Suites;
            NumDecks = _NumDecks;
            HouseMoney = _HouseMoney;
            HandSize = _HandSize;

            Deck = new Deck(Suites);

            Decks = Deck.CreateDecks(_NumDecks);
            Dealer = new Dealer(Decks, HandSize, HouseMoney);
            Player = new Player();
        }

        public void Start()
        {
            SpaceLine();
            Print("Welcome to");
            Print(Name+"!");

            SpaceLine();
            Print(Desc);
            SpaceLine();
            if(Question("What to play? (y/n)", "y", "n"))
            {
                DisplayClear();
                Loop();
            }
            else
            {
                Stop();
            }
        }
        public abstract void Loop();
        public void Stop()
        {
           CloseApp();
        }
    }
}

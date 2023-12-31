﻿using System;

namespace HomeTask4
{
    internal class Program
    {
        public static void Main()
        {
            //task4.1
            //var Deck = new CardDeck();
            //task4.2
            //Deck.ShuffleDeck();
            //task4.3
            //Deck.ReturnPositionOfAce();
            //task4.4
            //Deck.SwitchAllClubsOnBeginning();
            //Deck.PrintDeck();
            //task4.5
            //Deck.SortDeck();
            int playerScore = 0;
            int computerScore = 0;
            int gamesPlayed = 0;
            while (true)
            {
                Console.Clear();
                Game21 game = new Game21();
                string winner = game.PlayRound(); 

                if (winner == "Player")
                {
                    playerScore++;
                }
                else if (winner == "Computer")
                {
                    computerScore++;
                }
                gamesPlayed++;

                Console.WriteLine($"\nPlayer Score {playerScore} \\|/ Computer Score {computerScore}");
                Console.WriteLine($"Total Games Played {gamesPlayed}");
                Console.WriteLine("Do you want to play another round? (y/n)");

                string playAgain = Console.ReadLine().ToLower();

                if (playAgain != "y")
                {
                    Console.WriteLine("Thanks for playing!");
                    break;
                }
            }
        }
    }
}
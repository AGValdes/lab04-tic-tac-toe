﻿using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Board.DisplayBoard();
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Player playerOne = CreatePlayer();
            Player playerTwo = CreatePlayer();
            playerOne.IsTurn = true;
            Game newGame = MakeGame(playerOne, playerTwo);

            Player winner = newGame.Play(playerOne, playerTwo);

        }
        public static Player CreatePlayer()
        {
            Console.WriteLine("Player one please enter your name:");
            string userInput = Console.ReadLine();
            Player newPlayer = new Player()
            {
                Name = userInput
            };
            return newPlayer;
        }
        public static Game MakeGame(Player playerOne, Player playerTwo)
        {
            return new Game(playerOne, playerTwo);
        }

    }
}
/*
      Car johnsThirdCar = new Car()
      {
        Make = "Toyota Tundra",
        Color = "Red"
      };
*/

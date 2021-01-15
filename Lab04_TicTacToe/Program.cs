using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static Classes.Player[] playerContainer = new Classes.Player[2];

        static void Main(string[] args)
        {
            
            CreatePlayers();
            StartGame();
            
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
         
            Game newGame = MakeGame(playerContainer[0], playerContainer[1]);
            newGame.Play(playerContainer[0], playerContainer[1]);
           
            

        }
        public static void CreatePlayers()
        {

            Classes.Player PlayerOne = new Classes.Player();
            Classes.Player PlayerTwo = new Classes.Player();

            Console.WriteLine("Player one, please enter your name:");
            string PlayerOneName = Console.ReadLine();
            PlayerOne.IsTurn = true;
            PlayerOne.Name = PlayerOneName;
            PlayerOne.Marker = "X";

            Console.WriteLine("Player two, please enter your name:");
            string PlayerTwoName = Console.ReadLine();
            PlayerTwo.IsTurn = false;
            PlayerTwo.Name = PlayerTwoName;
            PlayerTwo.Marker = "O";

            playerContainer[0] = PlayerOne;
            playerContainer[1] = PlayerTwo;

            Console.WriteLine($"Your players are: {PlayerOne.Name}, {PlayerTwo.Name}");

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

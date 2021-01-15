using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe;

namespace Lab_04_tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestForAWinner()
        {
            Player player1 = new Player();
            player1.Name = "jane";
            player1.Marker = "O";

            Player player2 = new Player();
            player2.Name = "doe";
            player2.Marker = "X";

            Game newGame = new Game(player1, player2);

            Board testBoard = new Board()
            {
                GameBoard =
            new string[,]
            {
                {"X", "2", "1"},
                {"X", "5", "6"},
                {"X", "8", "9"},
            }

            };

            Assert.True(newGame.CheckForWinner(testBoard));
        }

        [Fact]
        public void CheckSwitch()
        {
            Player player1 = new Player();
            player1.Name = "Jane";
            player1.Marker = "X";
            player1.IsTurn = true;

            Player player2 = new Player();
            player2.Name = "Doe";
            player2.IsTurn = false;

            Game newgame = new Game(player1, player2);
            newgame.SwitchPlayer();

            Assert.True(player2.IsTurn);
        }

    }

        


}



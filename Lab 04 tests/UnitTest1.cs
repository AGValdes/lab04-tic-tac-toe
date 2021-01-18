using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe;

namespace Lab_04_tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_For_AWinner()
        {
            Player player1 = new Player();
            player1.Name = "jane";
            player1.Marker = "O";

            Player player2 = new Player();
            player2.Name = "doe";
            player2.Marker = "X";

            Game newGame = new Game(player1, player2);

            Board testBoard = new Board();
            testBoard.GameBoard = new string[,]
                {
                {"X", "2", "3"},
                {"X", "5", "6"},
                {"X", "8", "9"},


            };

            Assert.True(newGame.CheckForWinner(testBoard));
    }

        [Fact]
        public void Check_Switch()
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
        [Fact]
        public void Test_Index_Is_Correct()
        {
            Player player1 = new Player();
            player1.Name = "Jane";
            player1.Marker = "X";

            Player player2 = new Player();
            player2.Name = "Doe";

            Game testGame = new Game(player1, player2);
            Position position = new Position(0, 0);



            testGame.Board.GameBoard = new string[,]
            {
                {"X", "2", "1"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            };
            Assert.True(Player.PositionForNumber(1).Row == position.Row && Player.PositionForNumber(1).Column == position.Column);
        }
        [Fact]
        public void Test_For_Player_Names ()
        {
            Player player1 = new Player();
            player1.Name = "Jane";

            Assert.Equal(player1.Name, "Jane");
        }


    }

        


}



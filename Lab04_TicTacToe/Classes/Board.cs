using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public static void DisplayBoard()
		{

			//TODO: Output the board to the console
			Board GameBoard = new Board();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
					string row = "|" + GameBoard.GameBoard[i, j] + "|";
				Console.Write(row);

                }
				Console.WriteLine("\n");
            }
		
		}
	}
}

// string newRow = string.Join(" | ", GameBoard[i]);

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mission04___Team0103
{
    internal class Supporting
    {
        public void PrintBoard(char[] boardArray)
        {
            // iterate through every cell of the board / every value of the array
            for (int i = 0; i < boardArray.Length; i++)
            {
                // print out the value of the current cell
                Console.Write($" {boardArray[i]} ");
                // if current cell is the last cell in the row (cell 3, 6, or 9), proceed
                if ((i + 1) % 3 == 0)
                {
                    // create a new line
                    Console.WriteLine();
                    // if current cell is not the last cell of the board (cell 9), proceed
                    if (i < boardArray.Length - 1)
                    {
                        // print a row seperator
                        Console.WriteLine("---|---|---");
                    }
                }
                else
                {
                    // else, print a column seperator
                    Console.Write("|");
                }
            }
        }

        public string CheckWinner(char[] boardArray)
        {
            // Winning conditions
            int[,] winConditions = new int[,]
            {
                {0, 1, 2}, // Row 1
                {3, 4, 5}, // Row 2
                {6, 7, 8}, // Row 3
                {0, 3, 6}, // Column 1
                {1, 4, 7}, // Column 2
                {2, 5, 8}, // Column 3
                {0, 4, 8}, // Diagonal 1
                {2, 4, 6}  // Diagonal 2
             };

            for (int i = 0; i < 8; i++)
            {
                int a = winConditions[i, 0];
                int b = winConditions[i, 1];
                int c = winConditions[i, 2];

                // Check if the board has the winning combination
                if (boardArray[a] != ' ' && boardArray[a] == boardArray[b] && boardArray[b] == boardArray[c])
                {
                    // Return the winner ("Player one wins!" or "Player two wins!")
                    return boardArray[a] == 'X' ? "Player one wins!" : "Player two wins!";
                }
            }

            // Check if there are any empty spaces left
            foreach (char space in boardArray)
            {
                if (space == ' ') return null; // Game continues, no winner yet
            }

            // The game is a draw
            return "It's a tie!";
        }
    }
}

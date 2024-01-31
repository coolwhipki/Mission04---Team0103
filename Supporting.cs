using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission04___Team0103
{
    internal class Supporting
    {
        public void PrintBoard(char[] board)
        {
            // iterate through every cell of the board / every value of the array
            for (int i = 0; i < board.Length; i++)
            {
                // print out the value of the current cell
                Console.Write($" {board[i]} ");
                // if current cell is the last cell in the row (cell 3, 6, or 9), proceed
                if ((i + 1) % 3 == 0)
                {
                    // create a new line
                    Console.WriteLine();
                    // if current cell is not the last cell of the board (cell 9), proceed
                    if (i < board.Length - 1)
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

        IfWinner():
        {
            // if there are three X in a row
                // print("The winner is player 1 (X's)!") 
            // elseif: there are three O in a row
                // print ("The winner is play 2 (O's)!")
            // else: 
                // print("its a draw!")

        }
    }
}

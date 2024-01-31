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
        PrintBoard():
        {

        }

        public int IfWinner(int player)
        {
            //The player can only win if their figure (X or O) is the value 
            //of at least one of these items:

            // WinningOptions = [(boardArray[0], boardArray[1], boardArray[2]),
            //                   (boardArray[0], boardArray[4], boardArray[8]),
            //                   (boardArray[0], boardArray[3], boardArray[6]),
            //                   (boardArray[1], boardArray[4], boardArray[7]),
            //                   (boardArray[2], boardArray[4], boardArray[6]),
            //                   (boardArray[2], boardArray[5], boardArray[8]),
            //                   (boardArray[3], boardArray[4], boardArray[5]),
            //                   (boardArray[6], boardArray[7], boardArray[8])];

            bool gameOver = false;
            
            //loop until game is over (there is a winner or a tie)
            while  (gameOver == false)
            {
                //Check if any of the items on the board is still empty
                if (Array.Exists(boardArray, element => element == " "))
                { 
                    //if 'X' is the value in all three spots in one of the winningOptions 
                        //then print ("player 1 is the winner!");
                        //gameOver = true
                    //elseif 'O' is the value in all thee spots in one of the winningOptions
                        //then print ("player 2 is the winner!");
                        //gameOver = true
                    //else
                        //go back to the top of the if statement again
                //else = board is full
                    //if 'X' is the value in all three spots in one of the winningOptions 
                        //then print ("player 1 is the winner!");
                        //gameOver = true
                    //elseif 'O' is the value in all thee spots in one of the winningOptions
                        //then print ("player 2 is the winner!");
                        //gameOver = true
                    //else
                        //print ("its a tie!")
                        //gameOver = true 
                    ;
                }
            }
        }
    }
}

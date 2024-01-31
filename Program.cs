//Welcome user to game
Console.WriteLine("Welcome to Tic-Tac-Toe!!");
Console.WriteLine("Player 1 (X) - Player 2 (O)");



// Create a game board array to store the players’ choices
char[] boardArray = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };


int playerTurn = 0;


do
{

    if (playerTurn == 0)
    {
        Console.WriteLine("Player 1, what spot do you want");
    }
    else
    {
        Console.WriteLine("Plaer 2, what spot do you want");
    }


    if (playerTurn == 0)
    {
        playerTurn = 1;
    }
    else if (playerTurn == 1)
    {
        playerTurn = 0;
    }

} while MosMEthod() is null;
//Ask each player in turn for their choice and update the game board array
//if statement: if team 1 then 'X' if team 2 'O'
//if that spot already has something in it print something saying "no"
//update the game board array


//Print the board by calling the method in the supporting class

//Check for a winner by calling the method in the supporting class, and notify the players when a win has occurred and which player won the game
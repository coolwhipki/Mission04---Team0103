using Mission04___Team0103;


Supporting s = new Supporting();

// Create a game board array to store the players’ choices
char[] boardArray = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
// initialize player 1's turn
int playerTurn = 0;

//Welcome user to game
Console.WriteLine("Welcome to Tic-Tac-Toe!!");
Console.WriteLine("Player 1 (X) - Player 2 (O)");

String gameResult = "";

// Game Loop
do
{
    // Turn Loop
    do
    {
        Console.WriteLine($"Player {playerTurn + 1}, what spot do you want");

        // Print the board by calling the method in the supporting class
        s.PrintBoard(boardArray);

    } while (playGame(playerTurn));

    // switch to other player (shortened version)
    playerTurn = playerTurn == 0 ? 1 : 0;

    /* expanded switch player functionality
        if (playerTurn == 0) {
            playerTurn = 1;
        }
        else if (playerTurn == 1) {
            playerTurn = 0;
        } */

    // Check for a winner by calling the method in the supporting class,
    gameResult = s.CheckWinner(boardArray);
} while (gameResult == null);

// Print the board by calling the method in the supporting class
s.PrintBoard(boardArray);
// Display the Winner! notify the players when a win has occurred and which player won the game
Console.WriteLine(gameResult);


// Player Turn Function
bool playGame(int pT)
{
    // set a player choice variable integer
    int playerChoice = 0;

    // set playerLetter (shortened version)
    char playerLetter = pT == 0 ? 'X' : 'O';

    /* set playerLetter, expanded functionality
       char playerLetter = '';
       if (pT == 0) {
           playerLetter = 'X';
       }
       else if (pT == 1) {
           playerLetter = 'O';
       } */

    //Ensure input is valid
    while (true)
    {

        Console.Write("Enter which square to play on! (enter a number 1-9): ");
        string input = Console.ReadLine();


        if (int.TryParse(input, out playerChoice) && playerChoice >= 1 && playerChoice <= 9)
        {
            playerChoice--; // Minus 1 from input to make sure it is corresponding to correct position in the array

            // Check if the selected square is available
            if (boardArray[playerChoice] == ' ')
            {
                boardArray[playerChoice] = playerLetter;
                return false; // Valid input, exit the loop
            }
            else
            {
                Console.WriteLine("Oops! That spot is already taken, try again");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
        }
    }
}


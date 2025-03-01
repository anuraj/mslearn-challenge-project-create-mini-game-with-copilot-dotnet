//We are building a Rock Paper Scissors game.
//The player can choose one of the three options rock, paper, or scissors and should be warned if they enter an invalid option.
//By the end of each round, the player can choose whether to play again.
//The game will keep track of the player's score and display it at the end of each round.

Console.WriteLine("Welcome to Rock Paper Scissors!");

int playerScore = 0;
int computerScore = 0;

while (true)
{
    Console.WriteLine("Please enter your choice: rock, paper, or scissors.");
    var playerChoice = Console.ReadLine();
    string computerChoice = GetComputerChoice();

    if (string.IsNullOrEmpty(playerChoice))
    {
        Console.WriteLine("Invalid choice. Please enter rock, paper, or scissors.");
        continue;
    }
    else
    {
        playerChoice = playerChoice.ToLower();
    }

    if (playerChoice == "rock" || playerChoice == "paper" || playerChoice == "scissors")
    {
        Console.WriteLine($"Computer chose: {computerChoice}");

        if (playerChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                 (playerChoice == "paper" && computerChoice == "rock") ||
                 (playerChoice == "scissors" && computerChoice == "paper"))
        {
            Console.WriteLine("You win!");
            playerScore++;
        }
        else
        {
            Console.WriteLine("Computer wins!");
            computerScore++;
        }
    }
    else
    {
        Console.WriteLine("Invalid choice. Please enter rock, paper, or scissors.");
    }

    Console.WriteLine($"Player Score: {playerScore}");
    Console.WriteLine($"Computer Score: {computerScore}");

    Console.WriteLine("Do you want to play again? (yes/no)");
    var playAgain = Console.ReadLine();

    if (playAgain == null)
    {
        break;
    }

    if (playAgain.Equals("yes", StringComparison.OrdinalIgnoreCase))
    {
        continue;
    }
    else
    {
        break;
    }
}

Console.WriteLine("Thanks for playing!");

static string GetComputerChoice()
{
    var random = new Random();
    int randomNumber = random.Next(0, 3);

    return randomNumber switch
    {
        0 => "rock",
        1 => "paper",
        2 => "scissors",
        _ => throw new Exception("Invalid random number"),
    };
}
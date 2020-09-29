using System;

namespace RockPaperScissorsFTThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string computerInput;

            int userScore = 0;
            int computerScore = 0;

            while (userScore < 3 && computerScore < 3)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 4);

                Console.WriteLine("Choose either rock, paper or scissors.");
                userInput = Console.ReadLine().ToLower();

                if (randomNumber == 1)
                {
                    computerInput = "rock";
                }else if (randomNumber == 2)
                {
                    computerInput = "paper";
                }else
                {
                    computerInput = "scissors";
                }

                if (computerInput == userInput)
                {
                    Console.WriteLine($"It's a draw! The computer also chose {userInput}");
                }else if (userInput == "rock" && computerInput == "scissors")
                {
                    userScore++;
                    Console.WriteLine($"You scored! You now have {userScore} points and the computer has {computerScore} points.");
                }else if (userInput == "rock" && computerInput == "paper")
                {
                    computerScore++;
                    Console.WriteLine($"Computer scored! You have {userScore} points and the computer now has {computerScore} points.");
                }else if (userInput == "paper" && computerInput == "rock")
                {
                    userScore++;
                    Console.WriteLine($"You scored! You now have {userScore} points and the computer has {computerScore} points.");
                }else if (userInput == "paper" && computerInput == "scissors")
                {
                    computerScore++;
                    Console.WriteLine($"Computer scored! You have {userScore} points and the computer now has {computerScore} points.");
                }else if (userInput == "scissors" && computerInput == "paper")
                {
                    userScore++;
                    Console.WriteLine($"You scored! You now have {userScore} points and the computer has {computerScore} points.");
                }else if (userInput == "scissors" && computerInput == "rock")
                {
                    computerScore++;
                    Console.WriteLine($"Computer scored! You have {userScore} points and the computer now has {computerScore} points.");
                }else
                {
                    Console.WriteLine("Please enter either rock, paper or scissors in order to play this game.");
                }
            }
            if (userScore == 3)
            {
                Console.WriteLine("You stand victorious and the computer loses shamefully!");
            }else
            {
                Console.WriteLine("The computer stands victorious and you lose shamefully!");
            }
        }
    }
}

using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        int userScore = 0;
        int computerScore = 0;
       
        while (true)
        {
            Console.WriteLine("Lets play rock, paper, scissors! Enter your choice:");
            string userChoice =  Console.ReadLine();
            userChoice = userChoice.ToLower();
            string computerChoice = ComputerChoice();
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") || (userChoice == "scissors" && computerChoice == "paper") || (userChoice == "paper" && computerChoice == "rock"))
            {
                userScore++;
                Console.WriteLine("You win!");
            }
            else
            {
                computerScore++;
                Console.WriteLine("You lose!");
            }
                Console.WriteLine("You chose " + userChoice + " & computer chose " + computerChoice);
                Console.WriteLine("You: " + userScore + " Computer: " + computerScore);
            Console.WriteLine("Play again? Y/N");
            string playAgain = Console.ReadLine();
            playAgain = playAgain.ToLower();    
            if ((playAgain == "n") || (playAgain == "no"))
            {
                break;
            }
        }
    }
    static string ComputerChoice()
    {
            string[] choices = {"rock","paper","scissors"};
            Random random = new Random();
            int index = random.Next(choices.Length);
            return choices[index];
    }
}

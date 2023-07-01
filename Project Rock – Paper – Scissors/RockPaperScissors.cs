using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Project_Rock___Paper___Scissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            string playerMove = String.Empty;

            while (true)
            {
                Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors");
                Console.WriteLine("To end game enter - \"END\"");

                playerMove = Console.ReadLine();                

                if (playerMove == "r" || playerMove == "rock")          playerMove = Rock;
                else if (playerMove == "p" || playerMove == "paper")    playerMove = Paper;
                else if (playerMove == "s" || playerMove == "scissors") playerMove = Scissors;
                else if (playerMove == "END")
                {
                    Console.WriteLine("Bye!");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again....");
                    continue;
                }

                Random randomNumber = new Random();
                int computerRandomNumber = randomNumber.Next(1, 4);

                string computerMove = String.Empty;

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }

                Console.WriteLine($"Computer chose {computerMove}");

                if (playerMove == Rock && computerMove == Scissors || playerMove == Paper && computerMove == Rock || playerMove == Scissors && computerMove == Paper)
                {
                    Console.WriteLine("You win.");
                }
                else if (playerMove == Rock && computerMove == Paper || playerMove == Paper && computerMove == Scissors || playerMove == Scissors && computerMove == Rock)
                {
                    Console.WriteLine("You lose.");
                }
                else Console.WriteLine("This game was draw");
            }

            
        }
    }
}

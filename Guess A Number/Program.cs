using System;

namespace Guess_A_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);

           while (true)
           {
                Console.WriteLine("Guess a number (1-100): ");
                Console.WriteLine("EXIT to end Game!");

                string playerinput  = Console.ReadLine();

                if (playerinput == "EXIT") break;
               
                bool isvalid = int.TryParse(playerinput, out int playerNumber);

                if (isvalid && (playerNumber > 0 && playerNumber <= 100))
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High!");                       
                    }
                    else
                    {
                        Console.WriteLine("Too Low!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try Again!");
                }
           }
            Console.WriteLine("Buy!");





        }
    }
}

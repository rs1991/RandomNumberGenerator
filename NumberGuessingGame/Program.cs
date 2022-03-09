using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("------------------------------------");

            Random num = new Random();
            int guess;
            int actualNumber = num.Next(1, 100);
            bool playAgain = true;
            string answer;

            while (playAgain)
            {
                guess = 0;
                answer = "";
                actualNumber = num.Next(1, 100);


                while (guess != actualNumber)
                {
                    Console.WriteLine("Guess a number from 1 to 100: ");
                    guess = Convert.ToInt32(Console.ReadLine());


                    if (guess == actualNumber)
                    {
                        Console.WriteLine("YOU WIN!!!");
                    }
                    if (guess > actualNumber)
                    {
                        Console.WriteLine("Your guess is too high, the actual number is: " + actualNumber);
                    }
                    if (guess < actualNumber)
                    {
                        Console.WriteLine("Your guess is too low, the actual number is: " + actualNumber);
                    }
                }

                    Console.WriteLine("Would you like to play again? 'Y' for Yes and 'N' for No");
                    answer = Console.ReadLine();

                    if (answer == "Y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }


                }
                Console.WriteLine("Thanks for playing");
                Console.ReadKey();


            }

        }
    }

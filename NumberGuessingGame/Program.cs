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
            int noGuesses;
            int limit;
            int actualNumber = num.Next(1, 100);
            bool playAgain = true;
            string answer;


            while (playAgain)
            {

                guess = 0;
                limit = 3;
                noGuesses = 0;
                answer = "";
                actualNumber = num.Next(1, 100 + 1);

                while (guess != actualNumber)
                {

                    Console.WriteLine("Guess a number from 1 to 100: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    noGuesses++;

                    if (guess > actualNumber)
                    {
                        Console.WriteLine(guess + " Your guess is too high");
                    }

                    if (guess < actualNumber)
                    {
                        Console.WriteLine(guess + " Your guess is too low ");

                    }
                    int dif = guess - actualNumber;
                    int difAbs = Math.Abs(dif);

                    if (difAbs <= 5)
                        Console.WriteLine("You are close!");


                    if (guess == actualNumber)
                    {
                        Console.WriteLine(" YOU WIN!!! " + actualNumber);
                    }

                    if (noGuesses >= limit)
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("You lose, the correct number is " + actualNumber);
                        break;
                    }

                }

                Console.WriteLine("Would you like to play again? 'Y' for Yes and 'N' for No");
                answer = Console.ReadLine().ToUpper();

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

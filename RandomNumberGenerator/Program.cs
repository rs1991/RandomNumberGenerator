using System;

namespace RandomNumberGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int guess;
            int actualNumber = num.Next(1, 100);
      
            Console.WriteLine("Guess a number from 1 to 100: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess == actualNumber)
            {
                Console.WriteLine("YOU WIN!");
            }
            if (guess > actualNumber)
            {
                Console.WriteLine("Your guess is too high, the actual number is: "+actualNumber);
            }
            if (guess < actualNumber)
            {
                Console.WriteLine("Your guess is too low, the actual number is: "+actualNumber);
            }
        }
    }
}
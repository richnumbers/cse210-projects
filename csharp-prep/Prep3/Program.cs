using System;

class Program
{
    static void Main(string[] args)
    {
        int guess=0;
        int number = 7;
        string userInput;
        while (guess != number)
        {
            Console.WriteLine("Guess a number");
            userInput = Console.ReadLine();
            guess = int.Parse(userInput);
            if (guess < number)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (guess > number)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
            }
        }
    }
}
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        
        
        static string GetUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int NumberSquare(int number)
        {
            return number * number;
        }

        static void DisplayResult(string userName, int number, int square)
        {
            Console.WriteLine($"Hello {userName}, the square of {number} is {square}.");
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");

        }


        DisplayWelcome();
        string userName = GetUserName();
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int square = NumberSquare(number);
        DisplayResult(userName, number, square);




    }
}
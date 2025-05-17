using System;

class Program
{
   
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";
        Console.WriteLine("What are you donig today?");
        Console.WriteLine("1. Journal");
        choice = Console.ReadLine();
        if (choice == "1")
        {

            journal.Menu();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }

    }
}
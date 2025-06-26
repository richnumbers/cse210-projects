using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu of Activities");
        Console.WriteLine("1: Breathing Exercise");
        Console.WriteLine("2: Reflecting Exercise");
        Console.WriteLine("3: Listing Exercise");

        string choice;
        choice = Console.ReadLine();
    while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.WriteLine("Please select a valid activity (1, 2, or 3):");
            choice = Console.ReadLine();
        }
        if (choice == "1")
        {
            int duration;
            Console.Write("Enter the duration for the breathing exercise in seconds: ");
            duration = int.Parse(Console.ReadLine());
            Breathing breathing = new Breathing("Breathing Exercise", "Focus on your breathing to relax.", duration);
            Console.Clear();
            breathing.StartBreathingExercise();
        }
        else if (choice == "2")
        {
            int duration;
            Console.Write("Enter the duration for the reflecting exercise in seconds: ");
            duration = int.Parse(Console.ReadLine());
            reflecting reflecting = new reflecting("Reflecting Exercise", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration);
            Console.Clear();
            reflecting.StartReflectingExercise();
        }
        else if (choice == "3")
        {
            int duration;
            Console.Write("Enter the duration for the listing exercise in seconds: ");
            duration = int.Parse(Console.ReadLine());
            listing listing = new listing("Listing Exercise", "List things you are grateful for.", duration);
            Console.Clear();
            listing.StartListingExercise();
        }
    

        
    }
}
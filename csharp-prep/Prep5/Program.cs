using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        string name;
        string description;
        int points;
        int targetCount;
        int bonusPoints;
        int totalPoints = 0;
        bool isComplete = false;
        List<Goal> goal = new List<Goal>();
        LoadGoals(goal);

        Console.WriteLine("Welcome to the Goal Tracker!");

        while (input != "5")
        {
            Console.WriteLine();
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a simple goal");
            Console.WriteLine("2. Create an eternal goal");
            Console.WriteLine("3. Create a checklist goal");
            Console.WriteLine("4. Display a goal");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Creating a simple goal...");
                Console.Write("Enter goal name: ");
                name = Console.ReadLine();
                Console.Write("Enter goal description: ");
                description = Console.ReadLine();
                Console.Write("Enter points for the goal: ");
                points = int.Parse(Console.ReadLine());
                Goal simpleGoal = new Simple(name, description, points, isComplete);
                goal.Add(simpleGoal);
                Console.WriteLine($"Simple goal '{name}' created with {points} points.");
            }
            else if (input == "2")
            {
                Console.WriteLine("Creating an eternal goal...");

                Console.Write("Enter goal name: ");
                name = Console.ReadLine();
                Console.Write("Enter goal description: ");
                description = Console.ReadLine();
                Console.Write("Enter points for the goal: ");
                points = int.Parse(Console.ReadLine());
                Goal eternalGoal = new Eternal(name, description, points, isComplete);
                goal.Add(eternalGoal);
                Console.WriteLine($"Eternal goal '{name}' created with {points} points.");
            }
            else if (input == "3")
            {
                Console.WriteLine("Creating a checklist goal...");
                Console.Write("Enter goal name: ");
                name = Console.ReadLine();
                Console.Write("Enter goal description: ");
                description = Console.ReadLine();
                Console.Write("Enter points for the goal: ");
                points = int.Parse(Console.ReadLine());
                Console.Write("Enter target count for the checklist goal: ");
                targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing the checklist goal: ");
                bonusPoints = int.Parse(Console.ReadLine());
                Goal checklistGoal = new Checklist(name, description, points, isComplete, "Checklist", targetCount, bonusPoints);
                goal.Add(checklistGoal);
                Console.WriteLine($"Checklist goal '{name}' created with {points} points, target count {targetCount}, and bonus points {bonusPoints}.");
                // Logic for creating a checklist goal
            }
            else if (input == "4")
            {
                Console.WriteLine("Displaying a goal...");

                for (int i = 0; i < goal.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goal[i].getName()} - {goal[i].getDescription()} (Points: {goal[i].getPoints()})");
                    goal[i].getStatus();
                }

                Console.Write("Enter the number of the goal you want to display: ");
                int goalNumber = int.Parse(Console.ReadLine()) - 1;
                if (goalNumber < 0 || goalNumber >= goal.Count)
                {
                    Console.WriteLine("Invalid goal number.");
                    continue;
                }
                Goal selectedGoal = goal[goalNumber];
                Console.WriteLine($"Goal Name: {selectedGoal.getName()} as been selected.");
                Console.WriteLine();

                Console.WriteLine("What would you like to do with this goal?");
                Console.WriteLine("1. Record an event for this goal");
                Console.WriteLine("2. Go Back to the main menu");
                Console.Write("Enter your choice: ");
                string actionChoice = Console.ReadLine();
                if (actionChoice == "1")
                {
                    totalPoints += selectedGoal.recordEvent();
                    Console.WriteLine($"You have completed the goal: {selectedGoal.getName()} and earned {selectedGoal.getPoints()} points.");
                }
                else if (actionChoice == "2")
                {
                    continue;
                }

            }
            else if (input == "5")
            {
                Console.WriteLine("Saving goals to file...");
                SaveGoals(goal);
                Console.WriteLine("Exiting the program.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }








    }

    private static void SaveGoals(List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.getName()}|{goal.getDescription()}|{goal.getPointsValue()}|{goal.isComplete()}");
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }
    
    private static void LoadGoals(List<Goal> goals)
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        string name = parts[0];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        bool isComplete = bool.Parse(parts[3]);
                        Goal goal = new Simple(name, description, points, isComplete);
                        goals.Add(goal);
                    }
                }
            }
        }
    }
}
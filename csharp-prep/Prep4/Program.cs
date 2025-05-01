using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userInput;
        
        Console.WriteLine("Enter numbers (type 0 to stop): ");
        while (true)
        {
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput == 0)
            {
                break;
            }
            numbers.Add(userInput);
        }

         int sum =numbers.Sum();
        
        int count = numbers.Count();
        double average = (double)sum / count;
        numbers.Max();
        numbers.Min();
        numbers.Sort();
        
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {numbers.Max()}");
        Console.WriteLine($"The min is: {numbers.Min()}");
        

    }
}
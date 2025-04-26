using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string userInput;
        Console.WriteLine("What is your grade in %? ");
        userInput = Console.ReadLine();
        grade = int.Parse(userInput);
        int Remander = grade % 10;

                if (Remander >= 7 )
                {
                    if(grade >90)
                    {
                        userInput = "";
                    }
                    else
                    {
                    userInput = "+";
                    }
                }
                else if (Remander <= 3)
                {
                    userInput = "-";
                }
                else
                {
                    userInput = "";
                }
              
            
        
        if (grade >= 90)
        {
            Console.WriteLine("You got an A" + userInput+"!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You got a B" + userInput+"!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You got a C" + userInput+"!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You got a D" + userInput+"!");
        }
        else
        {
            Console.WriteLine("You got an F!");
        }
    }
}
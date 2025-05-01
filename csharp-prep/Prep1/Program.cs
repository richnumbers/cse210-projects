using System;

class Program
{
    
    static void Main(string[] args)
    {
        string fname;
        string lname;
        Console.WriteLine("what is your first name? ");
        fname = Console.ReadLine();
        Console.WriteLine("what is your last name? ");
        lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");   

       
    }
}
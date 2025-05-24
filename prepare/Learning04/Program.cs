using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(5);
        Fraction f2 = new Fraction(6, 0);
        Fraction f3 = new Fraction(7, 25);

        Console.WriteLine($"Fraction:  {f1.GetDecimalValue()}");
        Console.WriteLine($"Fraction:  {f2.GetDecimalValue()}");
        Console.WriteLine($"Fraction:  {f3.GetDecimalValue()}");
        Console.WriteLine($"Fraction:  {f1.GetFractionString()}");
        Console.WriteLine($"Fraction:  {f2.GetFractionString()}");
        Console.WriteLine($"Fraction:  {f3.GetFractionString()}");
    }
}
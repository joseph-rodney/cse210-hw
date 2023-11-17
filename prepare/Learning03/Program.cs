using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances for the three constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        // Display representation for each fraction
        DisplayFraction("Fraction 1", fraction1);
        DisplayFraction("Fraction 1", fraction2);
        DisplayFraction("Fraction 1", fraction3);
    }

    static void DisplayFraction(string label, Fraction fraction)
    {
        Console.WriteLine($"{label}: {fraction.GetTop()}/{fraction.GetBottom()}");
    }
}
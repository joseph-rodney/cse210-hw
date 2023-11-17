using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances using different constructors
        Fraction fraction1 = new Fraction();      // 1/1
        Fraction fraction2 = new Fraction(5);     // 5/1
        Fraction fraction3 = new Fraction(3, 4);  // 3/4
        Fraction fraction4 = new Fraction(1, 3);  // 1/3

        // Display representations for each fraction
        DisplayFraction("Fraction 1", fraction1);
        DisplayFraction("Fraction 2", fraction2);
        DisplayFraction("Fraction 3", fraction3);
        DisplayFraction("Fraction 4", fraction4);
    }

    static void DisplayFraction(string label, Fraction fraction)
    {
        Console.WriteLine($"{label}: {fraction.GetTop()}/{fraction.GetBottom()}");

        // Display fraction as a string
        Console.WriteLine($"String Representation: {fraction.GetFractionString()}");

        // Display decimal value of the fraction
        Console.WriteLine($"Decimal Value: {fraction.GetDecimalValue()}\n");
    }
}
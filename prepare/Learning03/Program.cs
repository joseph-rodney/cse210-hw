using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances for the three constructors(modified for step 5)
        Fraction fraction = new Fraction();

        // Step 5

        // Display intial values
        DisplayFraction("Initial Fraction", fraction);

        // Change the values using setters
        fraction.SetTop(5);
        fraction.SetBottom(2);

        // Display the new values
        DisplayFraction("New Values", fraction);
    }

    static void DisplayFraction(string label, Fraction fraction)
    {
        Console.WriteLine($"{label}: {fraction.GetTop()}/{fraction.GetBottom()}");
    }
}
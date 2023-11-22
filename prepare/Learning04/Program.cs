using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a simple assignment
        Assignment assignment = new Assignment("Kaneene", "Inheritance");

        // Calling the method to get the summary
        string summary = assignment.GetSummary();

        // Display the summary to the screen
        Console.WriteLine(summary);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a new assignment
        Assignment assignment = new Assignment("Kaneene", "Inheritance");
        // Creating a new mathAssignment
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");

        // Testing GetSummary method
        string summary = assignment.GetSummary();
        string summary1 = mathAssignment.GetSummary();

        // Testing GetHomeworkList method
        string homeworklist = mathAssignment.GetHomeworkList();


        // Display the summary and homeworklist to the screen
        Console.WriteLine(summary);
        Console.WriteLine(summary1);
        Console.WriteLine(homeworklist);

    }
}
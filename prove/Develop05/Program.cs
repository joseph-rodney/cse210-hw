using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string filename = "";

        Console.WriteLine("Welcome to the Goal Tracker program!");


        while (true)
        {
            // display menu options

            Console.WriteLine($"\n{goalManager.DisplayScore}");

            Console.WriteLine("\nMenu options:");
            Console.WriteLine("1. View goals and progress");
            Console.WriteLine("2. Create a new goal");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Save progress");
            Console.WriteLine("5. Load progress");
            Console.WriteLine("6. Exit");

            // read user input
            Console.Write("\nSelect a choice from the menu: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    goalManager.DisplayGoals();
                    break;

                case "2":
                    goalManager.CreateGoal();
                    break;

                case "3":
                    goalManager.RecordEvent();
                    break;

                case "4":
                    Console.WriteLine("Enter the name of the file: ");
                    filename = Console.ReadLine();
                    goalManager.SaveProgress(filename);
                    break;

                case "5":
                    Console.WriteLine("Enter the name of the file: ");
                    filename = Console.ReadLine();
                    goalManager.LoadProgress(filename);
                    break;

                case "6":
                    Console.WriteLine("Enter the name of the file: ");
                    filename = Console.ReadLine();
                    goalManager.SaveProgress(filename);
                    Console.WriteLine("Thank you for using the Goal Tracker program!");
                    return;

                default:
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                    break;
            }

            goalManager.DisplayScore();
        }
        
    }
}
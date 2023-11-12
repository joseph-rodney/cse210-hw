using System;

class Program
{
    static void Main(string[] args)
    {
                Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool continueProgram = true;

        Console.WriteLine("Welcome to the Journal Program:");

        while (continueProgram)
        {
            Console.WriteLine("\n1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("\nWhat would you like to do? ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    // Write
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Question: {randomPrompt}");
                    Console.Write("Your Answer: ");
                    string userAnswer = Console.ReadLine();
                    Entry newEntry = new Entry(DateTime.Now.ToString("dd/MM/yyyy"), randomPrompt, userAnswer);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully.");
                    break;

                case "2":
                    // Display
                    journal.DisplayAll();
                    break;

                case "3":
                    // Load
                    Console.Write("What is the filename? ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "4":
                    // Save
                    Console.Write("What is the name of the file? ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Entries saved to file successfully.");
                    break;

                case "5":
                    // Quit
                    continueProgram = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye! Program terminated.");
    
    }
}
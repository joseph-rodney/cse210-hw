using System;

class Program
{
    static void Main(string[] args)
    {
         // Example usage
        Journal journal = new Journal();
        Entry entry = new Entry("2023-11-12", "Sample Prompt", "Sample Entry Text");
        PromptGenerator promptGenerator = new PromptGenerator();

        journal.AddEntry(entry);
        journal.DisplayAll();
        journal.SaveToFile("journal.txt");
        journal.LoadFromFile("journal.txt");

        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Random Prompt: {randomPrompt}");
    }
}
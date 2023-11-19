using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Scripture instance with a single verse
        Scripture singleVerseScripture = new Scripture("In the beginning God created heaven and earth.", "Genesis", 1, 1);
        DisplayAndContinue(singleVerseScripture);

        // Create a Scripture instance with a verse range
        Scripture verseRangeScripture = new Scripture("For God so loved the world...", "John", 3, 16, 18);
        DisplayAndContinue(verseRangeScripture);

        Console.WriteLine("All words in the scriptures are now hidden. Program ends.");
    }

    static void DisplayAndContinue(Scripture scripture)
    {
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine("Scripture:");
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end the program.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                return;

            scripture.HideRandomWords(3); // Change the count as needed
        }
    }
}

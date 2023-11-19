using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Scripture instance with a single verse
        Scripture singleVerseScripture = new Scripture("In the beginning God created heaven and earth.", "Genesis", 1, 1);
        DisplayAndContinue(singleVerseScripture);

        // Create a Scripture instance with a verse range
        Scripture verseRangeScripture = new Scripture("For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life. For God did not send his Son into the world to condemn the world, but to save the world through him. Whoever believes in him is not condemned, but whoever does not believe stands condemned already because they have not believed in the name of God’s one and only Son.", "John", 3, 16, 18);
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

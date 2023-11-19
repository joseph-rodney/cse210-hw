using System;

class Program
{
    static void Main(string[] args)
    {
        // Craete a Scripture instance with a text and reference
        Scripture scripture = new Scripture("In the beginning God Created Heaven and Earth.", "Genesis", 1, 1);

        // Display the intital scripture text
        Console.WriteLine("Original Scripture:");
        Console.WriteLine(scripture.GetDisplayText());

        // Hide a random word
        Console.WriteLine("\nHiding a random word:");
        scripture.HideRandomWords(1);
        Console.WriteLine(scripture.GetDisplayText());

        // Reveal all the words
        Console.WriteLine("Revealing all words:");
        scripture.RevealAllWords();
        Console.WriteLine(scripture.GetDisplayText());
    }
}
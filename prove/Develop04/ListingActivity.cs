using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] _prompts = {
        "People you appreciate",
        "Your personal strengths",
        "People you have helped this week",
        "Times you felt the Holy Ghost this month",
        "Your personal heroes"
    };

    public ListingActivity() : base("Listing", "Helps you reflect on the good things in your life by listing as many as you can.")
    {
    }

    protected override void PerformActivity()
    {
        // Display the prompt for the user to consider
        Console.WriteLine($"Prompt: {_prompts[0]}");

        // Display a message indicating the start of the listing activity
        Console.WriteLine("Get ready to list...");
        Thread.Sleep(2000); // Pause for 2 seconds

        // Display a message instructing the user to start listing items
        Console.WriteLine("Start listing items:");

        // Loop to get items from the user based on the specified duration
        for (int i = 1; i <= _duration; i++)
        {
            Console.Write($"Item {i}: ");
            string item = Console.ReadLine();
            // Add item to the list or perform any necessary logic
            Thread.Sleep(1000); // Pause for 1 second between items
        }

        // Display the total number of items entered
        Console.WriteLine($"Total items entered: {_duration}");
    }
}
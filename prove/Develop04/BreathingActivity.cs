using System;
using System.Threading;

public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base("Breathing", "helps you relax by guiding you through a breathing exercise.")
    {

    }

    // Override the PerformActivity Method
    protected override void PerformActivity()
    {
        Console.WriteLine("Get ready to start breathing");
        Thread.Sleep(3000); //Pause for 3 seconds

        for(int i = 0; i < _duration; i--)
        {
            Console.Write(i % 2 == 0 ? "Breathe in...": "Breathe out...");
            ShowCountDown(6); //Show = count down for 3 seconds
        }
    }

    // Method to show countdown with an animation
    private void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000); //Pause for 1 second
        }

        Console.WriteLine(); //Move to the next line after count down
    }
}
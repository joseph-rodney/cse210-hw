using System;
using System.Threading;

public class Activity
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Method to display start message
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Starting {_name} Activity: {_description}");
        PrepareForActivity();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed the {_name} Activity for {_duration} seconds.");
        Thread.Sleep(2000); //Pause for 2 seconds
    }

    // Virtual class to allow derived classes to prepare for the actiivy
    public virtual void PrepareForActivity()
    {
        Console.WriteLine("Get ready ...");
        Thread.Sleep(3000); //Pause for 3 seconds
    }

    // Virtual method  to allow  derived class to to define their specific  activity logic
    public virtual void PerformActivity()
    {
        // This will be overridden by specific activities.
    }
}
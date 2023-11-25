using System;
using System.Threading;

public class Activity
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    // The Rum Method
    public void Run()
    {
        DisplayStartMessage();
        PerformActivity();
        DisplayEndingMessage();
    }

    // Method of the duration
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // Method to display start message
    protected void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity: {_description}");
        PrepareForActivity();
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed the {_name} Activity in {_duration} seconds.");
        Thread.Sleep(2000); //Pause for 2 seconds
    }

    // Virtual class to allow derived classes to prepare for the actiivy
    protected virtual void PrepareForActivity()
    {
        Console.WriteLine("Get ready ...");
        Thread.Sleep(3000); //Pause for 3 seconds
    }

    // Virtual method  to allow  derived class to to define their specific  activity logic
    protected virtual void PerformActivity()
    {
        // This will be overridden by specific activities.
    }
}
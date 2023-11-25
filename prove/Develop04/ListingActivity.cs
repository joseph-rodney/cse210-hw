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
}
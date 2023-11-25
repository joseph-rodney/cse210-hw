public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity: {_description}");
        ShowCountDown(3);
        Console.WriteLine("{Prepare to begin...}");
        ShowCountDown(2);
        Console.WriteLine("Go");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You have completed the {_name} activity.");
        Console.WriteLine($"Activity Duration: {_duration}");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = seconds; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Countdown: {i}");
            Thread.Sleep(1000);
        }
    }
}
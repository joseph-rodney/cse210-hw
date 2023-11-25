public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Helps you relax by walking you through Breathing in and out slowly", 0)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        for(int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);

            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}
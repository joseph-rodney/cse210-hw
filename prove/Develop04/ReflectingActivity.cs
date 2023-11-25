using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] _prompts = { "Stand up for someone else", "Do something really difficult", "Help someone in need", "Do something truly selfless" };

    public ReflectionActivity() : base("Reflection", "Helps you reflect on times when you've shown strength and resilience.")
    {
    }

    protected override void PepareForActivity()
    {
        base.PrepareForActivity();
        Console.WriteLine("Think deeply about the prompt...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected override void PerformActivity()
    {
        foreach (var prompt in _prompts)
        {
            Console.WriteLine($"Prompt: {prompt}");
            DisplayRandomQuestion();
            // Continue showing prompts and questions based on user-specified duration
        }
    }

    private void DisplayRandomQuestion()
    {
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random random = new Random();
        string randomQuestion = questions[random.Next(questions.Length)];

        Console.WriteLine($"Question: {randomQuestion}");
        Thread.Sleep(2000); // Pause for 2 seconds
    }
}
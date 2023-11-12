using System;

public class PromptGenerator
{
    // Attributes
    public List<string> _prompts = new List<string>{"Promp1", "Prompt2", "Prompt3"};

    // Methods
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}
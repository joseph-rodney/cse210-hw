using System;

public class Entry
{
    // Attributes 
    public string _date {get; private set;}
    public string _promptText{get; private set;}
    public string _entryText{get; private set;}

    // Methods
     public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} -> Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }
}
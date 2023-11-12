using System;
using System.Collections.Generic;
public class Journal
{
    // Attributes
    public List<Entry> _entries = new List<Entry>();

    // Methods
    public void AddEbtry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        // Implement the Logic to save a file
        Console.WriteLine($"Saving entries to file: {file}");
    }

    public void LoadFromFile()
    {
        // Implement the Logic to load entries from a file
        Console.WriteLine($"Loading entries from file: {file}");
    }
}
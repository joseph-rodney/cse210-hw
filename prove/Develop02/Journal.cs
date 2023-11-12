using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    // Attributes
    private List<Entry> _entries = new List<Entry>();

    // Methods
    public void AddEntry(Entry newEntry)
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

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry._date}#{entry._promptText}#{entry._entryText}");
                }
            }

            Console.WriteLine($"Entries saved to file: {file}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving entries to file: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
            try
        {
            _entries.Clear();

            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('#');
                    if (parts.Length == 3)
                    {
                        string date = parts[0];
                        string promptText = parts[1];
                        string entryText = parts[2];

                        Entry loadedEntry = new Entry(date, promptText, entryText);
                        _entries.Add(loadedEntry);
                    }
                }
            }

            Console.WriteLine($"Entries loaded from file: {file}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading entries from file: {ex.Message}");
        }
    }
}
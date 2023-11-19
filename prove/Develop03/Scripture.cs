using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string text, string book, int chapter, int verse)
    {
        _reference = new Reference(book, chapter, verse);
        InitializeWords(text);
    }

    public Scripture(string text, string book, int chapter, int startVerse, int endVerse)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        InitializeWords(text);
    }

    private void InitializeWords(string text)
    {
        _words = new List<Word>();
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n";

        foreach (Word word in _words)
        {
            displayText += $"{word.GetDisplayText()} ";
        }

        return displayText.Trim();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public void RevealAllWords()
    {
        foreach (Word word in _words)
        {
            word.Reveal();
        }
    }
}

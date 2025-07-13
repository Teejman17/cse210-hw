using System;
using System.IO;

public class Journal
{
    public List<string> _entry = new List<string>();
    PromptGenerator GetPrompt = new PromptGenerator();

    public void AddEntry()
    {
        Entry newEntry = new Entry();
        string prompt = GetPrompt.GetPrompt();
        Console.WriteLine($"{prompt}");
        Console.Write("> ");
        string entry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();
        _entry.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (string entry in _entry)
        {
            Console.WriteLine($"Entry: {entry}");
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Please enter file name you would like to save to: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string entry in _entry)
            {
                outputFile.WriteLine(entry);
            }
        }

    }

    public void LoadFromFile()
    {
        Console.WriteLine("Please enter the file name you would like to load from: ");
        string fileName = Console.ReadLine();
        _entry.AddRange(System.IO.File.ReadAllLines(fileName));
    }
}
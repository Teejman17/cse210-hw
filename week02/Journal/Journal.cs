using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    public List<Entry> _entry = new List<Entry>();
    PromptGenerator GetPrompt = new PromptGenerator();


    public void AddEntry()
    {
        Entry newEntry = new Entry();
        string prompt = GetPrompt.GetPrompt();
        Console.WriteLine($"{prompt}");
        Console.Write("> ");
        string entry = Console.ReadLine();
        newEntry._date = DateTime.Now;
        newEntry._promptText = prompt;
        newEntry._entryText = entry;
        _entry.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entry)
        {
            Console.WriteLine($"Entry: {entry.Display}");
        }

    }

    public void SaveToFile()
    {
        Console.WriteLine("Please enter file name you would like to save to: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in _entry)
            {
                outputFile.WriteLine(entry);

            }

        Console.WriteLine("Journal saved successfully");
                // catch error saving journal
            
        }

    }

    public void LoadFromFile()
    {
        Console.WriteLine("Please enter the file name you would like to load from: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);            
        }
        
    }
}
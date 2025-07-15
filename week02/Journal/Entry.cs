using System;

public class Entry
{
    public DateTime _date = DateTime.Now;
    public string _promptText;
    public string _entryText;

    // DateTime _date = DateTime.Now;
    // string dateText = _date.ToShortDateString();
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}
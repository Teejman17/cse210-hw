using System;
using System.Threading;
using System.Collections.Generic;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.Write("How long in seconds would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great job!");
        ShowSpinner(4);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        Thread.Sleep(5000);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "/", "-", "\\", "-", "|" };
        DateTime startTime = DateTime.Now;
        DateTime endTIme = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTIme)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(350);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
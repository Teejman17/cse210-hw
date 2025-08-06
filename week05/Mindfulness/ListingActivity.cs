using System;
using System.Threading;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count = -1;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many ideas as you can on the following topic:");
        DisplayPrompt();
        Console.WriteLine();
        Console.Write("Begin in: ");
        ShowCountDown(5);

        _count = GetList();

        Console.WriteLine($"You listed {_count} ideas.");

        DisplayEndingMessage();
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"{_prompts[index]}");
    }

    public int GetList()
    {
        int listCount = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("--");
            string userIdea = Console.ReadLine();

            if (userIdea.Trim().Length > 0)
            {
                listCount++;
            }

        }
        return listCount;
    }

}
using System;
using System.Threading;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
        : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Take the time to reflect on the following prompt:");
        DisplayPrompt();
        ShowCountDown(15);
        Console.WriteLine("Now, reflect on your answer to the following questions regarding the prompt you just read:");
        ShowCountDown(7);

        DateTime startTime = DateTime.Now;
        DateTime endTIme = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTIme)
        {
            DisplayQuestion();
            ShowSpinner(15);
        }

        DisplayEndingMessage();
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"Prompt: {_prompts[index]}");
    }

    public void DisplayQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        Console.WriteLine($"Question: {_questions[index]}");

    }
}
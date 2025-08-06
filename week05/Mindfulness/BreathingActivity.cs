using System;
class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")

    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());


        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in . . . .");
            ShowCountDown(4);

            Console.WriteLine("Now breath out . . . .");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
}
}


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";

        if (grade >= 90)
        {
            //Console.WriteLine("Your grade is an A");
            letter = "A";
        }
        else if (grade >= 80)
        {
            // Console.WriteLine("Your grade is a B");
            letter = "B";
        }
        else if (grade >= 70)
        {
            // Console.WriteLine("Your grade is a C");
            letter = "C";
        }
        else if (grade >= 60)
        {
            // Console.WriteLine("Your grade is a D");
            letter = "D";
        }
        else
        {
            // Console.WriteLine("Your grade is an F");
            letter = "F";
        }

        Console.WriteLine($"Your grad is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Please study harder next time!");
        }
    }
}
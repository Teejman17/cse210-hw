using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string selection = "-1";

        while (selection != "5")
        {
            Journal journal = new Journal();

            Console.WriteLine("Please select one of the following choices (1-5): ");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Your choice: ");

            selection = Console.ReadLine();

            if (selection == "1")
            {
                journal.AddEntry();
            }

            else if (selection == "2")
            {
                journal.DisplayAll();
            }

            else if (selection == "3")
            {
                journal.SaveToFile();
            }

            else if (selection == "4")
            {
                journal.LoadFromFile();
            }

            else
            {
                Console.WriteLine("Thank you, goodbye.");
            }

        }
    }
}
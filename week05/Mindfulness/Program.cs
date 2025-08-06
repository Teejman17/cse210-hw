using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1 - Start breathing activity");
            Console.WriteLine("2 - Start reflecting activity:");
            Console.WriteLine("3 - Start listing activity:");
            Console.WriteLine("4 - Quit");
            Console.Write("Select a choice (number) from the menu: ");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;

                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;

                case "4":
                    Console.WriteLine("Thank you, have a nice day!");
                    return;    
                
            }
        }
    }

}
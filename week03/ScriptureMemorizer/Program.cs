using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, scriptureText);

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string userResponse = Console.ReadLine();

            if (userResponse.ToLower() == "quit")
                break;

            HideRandomWords(scripture, 3);
        } while (!scripture.CompleteHidden());

        Console.Clear();
        Console.WriteLine("Congratulations! You've practiced memorizing the scripture.");
        // Console.WriteLine($"{scripture.GetDisplayText()} {scriptureText}");
    


        static void HideRandomWords(Scripture scripture, int wordToHide)
        {
            scripture.HideRandomWords(wordToHide);
        }
    }
}
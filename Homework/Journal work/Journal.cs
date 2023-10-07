/*  I want this class to be the hub, directing where you go depending on the response
    */

using System.Diagnostics;
using System.Xml;

public class Journal
{
    public static void menuPlace()
    {
        bool active = true;
        while (active == true)
        {
            Console.WriteLine("Welcome, please choose an option.");
            Console.WriteLine("1. Make new journal entry.");
            Console.WriteLine("2. Load past journal entries.");
            Console.WriteLine("3. End program.");
            Console.Write($"->");
            var whereTo = Console.ReadLine();

            if (whereTo == "1")
            {
                Entry.GetJournalEntry();
            }
            else if (whereTo == "2")
            {
                Entry.pastEntries();
            }
            else
            {
                System.Environment.Exit(0);
                
            }
        }
    }

    public void execute()
    {
        menuPlace();
    }
}
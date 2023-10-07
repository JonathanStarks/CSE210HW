/*  This class will do the updating work for the program
    
    Have classes such as 
    *Date
    *Response
    *And have these classes updated to the journal. 
    */
using System.Globalization;
using System.IO;

public class Entry {
    public Entry()
    {

    }
   
    public static void pastEntries()
    {
        string filename = "myFile.txt";
        string lines = System.IO.File.ReadAllText(filename);

        Console.WriteLine(lines);
        
    }
    
    public static void GetJournalEntry()
    {
        Console.Write($"Would you like a prompt? yes/no: ");
        var choice = Console.ReadLine();

        // If the user wants to make an entry the program will continue, if not, it will end.
        if (choice == "yes")
        {
            // Shows prompts
            Prompt.DisplayPrompts();

            // Has the user enter their journal entry
            Console.Write($"Please type your entry:");

            // Saves the entry to a varyable
            string thisEntry = Console.ReadLine();

            // If the user types yes, the journal entry will be saved to the entry list
            Console.Write($"Save this journal entry? (yes/no): ");
            choice = Console.ReadLine();
            if (choice == "yes")
            {
                using (StreamWriter outputFile = new StreamWriter("myFile.txt"))
                {
                    string fileName = "myFile.txt";
                    outputFile.WriteLine($"{DateTime.Now} {thisEntry}");
                }
                Console.WriteLine("Entry saved.");
                
                Journal.menuPlace();
            }
            else 
            {
                Console.WriteLine("Entry not saved.");
                Journal.menuPlace();
            }
        }
        else
        {
             // Has the user enter their journal entry
            Console.Write($"Please type your entry:");

            // Saves the entry to a varyable
            string thisEntry = Console.ReadLine();

            // If the user types yes, the journal entry will be saved to the entry list
            Console.Write($"Save this journal entry? (yes/no): ");
            choice = Console.ReadLine();
            if (choice == "yes")
            {
                using (StreamWriter outputFile = new StreamWriter("myFile.txt"))
                {
                    string fileName = "myFile.txt";
                    outputFile.WriteLine($"{DateTime.Now} {thisEntry}");
                }
                Console.WriteLine("Entry saved.");
                
                Journal.menuPlace();
            }
            else 
            {
                Console.WriteLine("Entry not saved.");

                Journal.menuPlace();
            }
        }
        }
    }

    

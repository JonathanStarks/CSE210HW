/*  This should be a list of prompts that should help the user to make a journal entry.
    *The one thing this class should do is randomly select a prompt then display that prompt.
    */

using System.Security.Cryptography.X509Certificates;

public class Prompt 
{
    public List<string> promptList = new List<string>() 
        {
            "Where have you seen the Lord's hand in your life today?",
            "What did you do today?",
            "What went right today, what went wrong?"
        };
    
    
    // Displays the prompts
    

    // Lets the Entry class use the DisplayPrompts method
    public static void DisplayPrompts()
    {
        foreach (string o in new List<string>(){
            "Where have you seen the Lord's hand in your life today?",
            "What did you do today?",
            "What went right today, what went wrong?"
        })
        {
            Console.WriteLine($"Question: {o}");
        }
        
    }


    
    public Prompt()
    {
        
    }




}
// Make a function that will randomly choose a prompt.

// Make a function that displays the prompt.
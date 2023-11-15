using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography;
using System.Xml.Serialization;

public class Reflection : Menu
{
    string _name;
    // = "reflection";

    string _description;
    // = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    int _time;

    public Reflection(string name, string description, int time) : base(name, description, time)
    {
        _name = name;

        _description = description;

        _time = time;
    }

    public List<string> _prompts = new List<string>()
    {
        "When was a time in your life when you stopped to help another?",
        "Have you told your mother you love her recently?",
        "When is a time that you made your father proud?",
        "When was the last time you were patient with someone?"
    };

    public List<string> _followUpPrompts = new List<string>()
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

    public void RandomPrompt()
    {
        Random randomNumber = new Random();
        int index = (int) randomNumber.Next(0, 3);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }

    public void GoThroughFollowUps()
    {
        RandomPrompt();
        
        // What I want this to do is to have this section run as long as there is still time left.
        // Make two datetime varyables, one that is now and one that is now + _time, at the end of each loop update the now datetime, the loop should keep going as long as the
        // now datetime is less than the future datetime.
        int i = 0;
        // get time divide by how long we want to prompt them
        // assuming 5 seconds per each
        int j = GetTime()/5;
        Overridetime(5);
        while (j > 0)
        {
            Console.WriteLine(_followUpPrompts[i]);
            TimerAnimation();
            j--;
            i++;
        }
    }
    public void ReflectionInstructions()
    {
        StartingMessage();
        Console.WriteLine(_description);
        SetTime();
        GoThroughFollowUps();
    }
}
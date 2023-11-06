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

    List<string> _prompts = new List<string>();

    public void ReflectionInstructions()
    {
        StartingMessage();
        Console.WriteLine(_description);
        SetTime();
        TimerAnimation();
    }
}
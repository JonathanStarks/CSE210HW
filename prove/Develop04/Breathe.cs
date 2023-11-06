using System.Runtime.InteropServices;

public class Breathe : Menu
{
    string _name;

    string _description;
    // = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    int _time;
    // = 0;

    public Breathe(string name, string description, int time) : base(name, description, time)
    {
        _name = name;

        _description = description;

        _time = time;
    }

    public void BreatheIn()
    {
        Console.Clear();
        _time = _time / 4;
        Console.Write($"Breathe in ");
        TimerAnimation();
        Console.Clear();
        Console.Write($"Breathe out ");
        TimerAnimation();
        Console.Clear();
        Console.Write($"Breathe in ");
        TimerAnimation();
        Console.Clear();
        Console.Write($"Breathe out ");
        TimerAnimation();

    }

    public void BreathingInstructions()
    {
        StartingMessage();
        Console.WriteLine(_description);
        SetTime();
        BreatheIn();
    }
}
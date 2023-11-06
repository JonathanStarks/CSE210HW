public class Listen : Menu
{
    string _name;
    // = "listening";

    string _description;
    // = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    int _time;

    public Listen(string name, string description, int time) : base(name, description, time)
    {
        _name = name;

        _description = description;

        _time = time;
    }

    public void ListeningInstructions()
    {
        StartingMessage();
        Console.WriteLine(_description);
        SetTime();
        TimerAnimation();
    }
}
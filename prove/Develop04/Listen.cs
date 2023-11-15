public class Listen : Menu
{
    string _name;
    // = "listening";

    string _description;
    // = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    int _time;

    List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void RandomPrompt()
    {
        Random randomNumber = new Random();
        int index = (int) randomNumber.Next(0, 3);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }

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
        RandomPrompt();
        DateTime StartingTime = DateTime.Now;
        DateTime CurrentTime = DateTime.Now;
        //TimeOnly length = new TimeOnly(_time);
        DateTime FutureTime = StartingTime.AddSeconds(_time);
        int i = 0;
        while (CurrentTime < FutureTime)
        {
            Console.Write("Answer question here: ");
            i++;
            CurrentTime = DateTime.Now;
        }
        TimerAnimation();
    }
}
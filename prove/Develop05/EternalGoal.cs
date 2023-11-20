public class Eternal : Goal
{   
    string _title;
    
    List<string> _eternalGoals = new List<string>()
    {
        "1) Read your scriptures.",
        "2) Say your prayers.",
        "3) Go to church.",
        "4) Do some service for another."
    };

    public Eternal(string title, string description, int points) : base(title, description, points)
    {
        _title = title;
    }

    public override void DisplayGoal()
    {
        Console.Clear();
        foreach (string x in _eternalGoals)
        {
            Console.WriteLine(x);
        }
        //return base.DisplayGoal();
    }
}
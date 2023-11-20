using System.IO.Compression;
using Microsoft.VisualBasic;

public class Basic : Goal
{
    //bool _completed;

    string _title;

    int _points;

    public Basic(string title, string description, int points) : base(title, description, points)
    {
        _title = title;
    }

    List<string> _basicGoals = new List<string>()
    {
        "1) Get a job.",
        "2) Buy a house.",
        "3) Pay off student loans.",
        "4) Get married."
    };


    public override void DisplayGoal()
    {
        Console.Clear();
        foreach (string x in _basicGoals)
        {
            Console.WriteLine(x);
        }
        //return base.DisplayGoal();
    }

    


}
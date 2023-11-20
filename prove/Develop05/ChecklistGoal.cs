

public class Checklist : Goal
{
    int _completePoints;

    int _targetReps;

    int _timesDone;

    bool _goalsAllDone = false;

    string _title;

    List<string> _listGoals = new List<string>()
    {
        "1) Make bed.",
        "2) Brush teeth.",
        "3) Do chores.",
        "4) Do Homework"
    };

    public Checklist(string title, string description, int points) : base(title, description, points)
    {
        _title = title;
    }

    // public override int AddPoints()
    // {
    //     // If all the goals in the checklist are completed
    //     return base.AddPoints();
    // }

    // public override List<string> CompleteGoal()
    // {
    //     return base.CompleteGoal();
    // }

    public override void DisplayGoal()
    {
        Console.Clear();
        foreach (string x in _listGoals)
        {

            Console.WriteLine(x);
        }
        //return base.DisplayGoal();
    }
}
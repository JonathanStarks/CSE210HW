public class Goal
{
    protected string _title;

    protected string _description;

    protected int _points;

    protected bool _goalDone;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    

    public int GoalSubMenu()
    {
        Console.Clear();
        Console.WriteLine($"----{_title} Goal Menu----");
        Console.WriteLine("1) Report a finished goal.");
        Console.WriteLine("2) Display goals.");
        Console.WriteLine("3) Return to Main Menu.");
        Console.Write("->");
            int answer = System.Int32.Parse(Console.ReadLine());
            if (answer == 1)
            {
                // Asks the user what goal they did, and depending on where in the list the goal is the program will not allow them to do that goal again.
                Console.WriteLine("What doal did you do?");
                DisplayGoal();
                Console.Write("Goal #: ");
                answer = System.Int32.Parse(Console.ReadLine());
                // Something goes here from -G-o-a-l-T-r-a-c-k-e-r- SavePoints that will save the points to a file and not let the user do the goal again.
                if (_goalDone == false)
                {
                    _points = 100;
                    SavePoints();
                    _points = 0;
                }
                return _points;
            }
            else if (answer == 2)
            {
                DisplayGoal();
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                GoalSubMenu();
            }
            else if (answer == 3)
            {
                return 0;
            }
            return 0;
    }

    // public virtual int AddPoints()
    // {
    //     // Console.WriteLine("What goal did you do?");
    //     // DisplayGoal();
    //     return _points;
    // }

    public virtual void DisplayGoal()
    {
        return;
    }
    
    string filename = "myFile.txt";
    
    public void SavePoints()
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            //Something will go here that will change the amount of points added based on what goal is done
            outputFile.WriteLine($"{_points}, ", FileMode.Append);
        }
    }

    public void LoadPoints()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        string justWork = File.ReadAllText(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Console.WriteLine(parts);

        }

        Console.WriteLine(justWork);

        Console.WriteLine("Press enter to continue.");
        Console.ReadLine();
    }



    // public virtual List<string> CompleteGoal()
    // {
    //     return _finishedGoals;
    // }
    
    //protected List<string> _finishedGoals = new List<string>();

    // public void AddTitle()
    // {
        
    // }

    // public void AddDescription()
    // {
        
    // }
}
using System.IO;
public class GoalTracker
{
    // public List<string> _goals = new List<string>
    // {

    // };

    string filename = "myFile.txt";
    public void SavePoints()
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            //Something will go here that will change the amount of points added based on what goal is done
            outputFile.WriteLine("_points");
        }
    }

    public void LoadPoints()
    {
        
    }
}
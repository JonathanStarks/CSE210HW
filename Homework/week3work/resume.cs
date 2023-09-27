public class Resume {
    private string _name;

    private List<Job> _jobs = new List<Job>();

    public Resume(string name)
    {
        _name = name;
    }

    public void AddJob(Job j)
    {
        _jobs.Add(j);
    }
    public void Display() {
        Console.WriteLine($"NAME: {_name}");
        foreach (Job j in _jobs)
        {
            j.showJobInfo();
        }
    }
}
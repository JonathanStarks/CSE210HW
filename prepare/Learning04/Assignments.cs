public class Assignments
{
    private string _studentName;

    private string _topic;

    public Assignments(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public void GetSummary()
    {
        Console.WriteLine($"Name: {_studentName}");
        Console.WriteLine($"Topic: {_topic}");
    }
}
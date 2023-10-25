public class WritingAssignments : Assignments
{
    private string _title;

    public WritingAssignments(string title, string studentName, string topic) : base (studentName, topic)
    {
        _title = title;
    }

    public void DisplayWrit()
    {
        GetSummary();
        Console.WriteLine($"Title: {_title}");
    }
}
public class MathAssignments : Assignments
{
    private string _textbookSection;

    private string _problems;

    public MathAssignments(string textbookSection, string problems, string studentName, string topic) : base (studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public void DisplayMath()
    {
        GetSummary();
        Console.WriteLine($"Textbook Section: {_textbookSection}");
        Console.WriteLine($"Problems: {_problems}");
    }
}
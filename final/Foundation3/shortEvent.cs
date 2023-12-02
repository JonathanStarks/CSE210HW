public class ShortInfo : Event
{
    string _eventType;

    public ShortInfo(string eventType, string name, string dateNTime) : base(name, null, dateNTime, null)
    {
        _eventType = eventType;
    }

    public void DisplayShortInfo()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Date: Sept. 21");
    }
}
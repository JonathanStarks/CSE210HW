using System.Security.Cryptography.X509Certificates;

public class FullEvent : Event
{
    // _eventType must be set to a specific string or else it won't work.
    // It must be set to something like: Lecture, Reception, Outdoor, ext. 
    // The program will check for this specific word and if it isn't there it won't
    // work.
    string _eventType;

    string _moreDetails;

    public FullEvent(string name, string description, string dateNTime, string address, string eventType/*, string moreDetails*/) : base (name, description, dateNTime, address)
    {
        //_name = name;

        //_description = description;

        //_dateNTime = dateNTime;

        //_address = address;

        _eventType = eventType;

        //_moreDetails = moreDetails;
    }

    public void CheckEventType()
    {
        if (_eventType == "Lecture")
        {
            _moreDetails = "For a lecture you will need to bring a notebook and something to write with. There will be a limited capacity of 100 people, admitance is on a FCFS basis.";
            DisplayFullInfo();
        }
        else if (_eventType == "Reception")
        {
            _moreDetails = "For a reception you will need to register for attendance.";
            DisplayFullInfo();
        }
        else if (_eventType == "Outdoor")
        {
            _moreDetails = "There will be no restrictions for attending this outdoor event, however, it should be noted that there is a catagory 8 hurricane akin to the Great Red Spot on Jupiter, in the forcast for this date.";
            DisplayFullInfo();
        }
        else
        {
            Console.WriteLine("Error: Invalid event type.");
            return;
        }
    }

    public void DisplayFullInfo()
    {
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine();
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine();
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine();
        Console.WriteLine($"When: {_dateNTime}");
        Console.WriteLine();
        Console.WriteLine($"Where: {_address}");
        Console.WriteLine();
        Console.WriteLine($"Additional Information: {_moreDetails}");

    }
}
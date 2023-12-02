public class Event
{
    protected string _name;

    protected string _description;

    protected string _dateNTime;

    protected string _address;

    public Event(string name, string description, string dateNTime, string address)
    {
        _name = name;

        _description = description;

        _dateNTime = dateNTime;

        _address = address;
    }
}
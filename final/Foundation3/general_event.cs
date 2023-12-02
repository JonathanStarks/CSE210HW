public class General : Event
{
    public General(string name, string description, string dateNTime, string address) : base (name, description, dateNTime, address)
    {
        //_name = name;

        //_description = description;

        //_dateNTime = dateNTime;

        //_address = address;
    }
    public void DisplayGeneral()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"When: {_dateNTime}");
        Console.WriteLine($"Where: {_address}");
    }
}
public class Running : Activity
{
    public Running(string name, double distance, double timeTaken) : base(name, distance, timeTaken)
    {

    }

    public override double GetSpeed()
    {
        return _speed = _distance / _timeTaken * 60 * 60;
    }

    public override string GetSummary()
    {
        DateTime time = DateTime.Now;
        Console.WriteLine(time);
        Console.WriteLine($"Title: {_name}");
        Console.WriteLine($"Distance: {_distance} Miles");
        Console.WriteLine($"Time (Min): {System.Math.Round(_timeTaken / 60, 2)}");
        Console.WriteLine($"Average Speed: {System.Math.Round(_speed, 2)} Miles per Hour");
        double _pace = 60 / _speed;
        Console.WriteLine($"Pace: {System.Math.Round(_pace, 2)} Minutes per mile");
        return _name;
    }
}
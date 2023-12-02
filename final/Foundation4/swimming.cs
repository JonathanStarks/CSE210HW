public class Swimming : Activity
{
    public Swimming(string name, double distance, double timeTaken) : base(name, distance, timeTaken)
    {

    }

    public override double GetSpeed()
    {
        return _speed = _distance / _timeTaken * 60;
    }

    public override string GetSummary()
    {
        DateTime time = DateTime.Now;
        Console.WriteLine(time);
        Console.WriteLine($"Title: {_name}");
        Console.WriteLine($"Laps Finished: {_distance}");
        Console.WriteLine($"Distance Swam: {System.Math.Round(_distance * 50 / 1609, 2)} Miles");
        Console.WriteLine($"Time (Min): {System.Math.Round(_timeTaken / 60, 2)}");
        Console.WriteLine($"Average Speed: {System.Math.Round(_speed, 2)} Laps per minute");
        _speed = 60 * _speed;
        double _pace = 60 / _speed;
        Console.WriteLine($"Pace: {System.Math.Round(_pace, 2)} Minutes per Lap");
        return _name;
    }
}
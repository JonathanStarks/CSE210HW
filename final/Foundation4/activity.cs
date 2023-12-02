public class Activity
{
    // Name of activity. IE running, swimming, or cycling.
    protected string _name;

    // Distance traveled, actual or simulated. For swimming this will be divided by the length of the pool lane to calculate laps done.
    protected double _distance;

    // Time Taken will be used to calculate the average speed during the activity.
    protected double _timeTaken;

    protected double _speed;

    public Activity(string name, double distance, double timeTaken)
    {
        _name = name;
        _distance = distance;
        _timeTaken = timeTaken;
    }

    public virtual double GetSpeed()
    {
        return _speed = _distance / _timeTaken;
    }

    public virtual string GetSummary()
    {
        return GetSummary();
    }
}
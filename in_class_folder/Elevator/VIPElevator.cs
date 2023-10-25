public class VIP: Elevator
{
    private string _elevatorCode = "1234";

    private int _topFloor = 31;


/*
    public VIP(string elevatorCode, bool doorsOpen, string currentFloor, ) : base(currentFloor, doorsOpen)
    {

    }
    */

    public VIP(string elevatorCode, int topFloor)
    {
        _elevatorCode = elevatorCode;
        _topFloor = topFloor;
    }

    
}
public class Elevator
{
    protected bool _doorsOpen = false;

    protected int _currentFloor;

    protected int _floors = 30;

    public Elevator(bool doorsOpen, int currentFloor, int floors)
    {
        _doorsOpen = doorsOpen;
        _currentFloor = currentFloor;
        _floors = floors;
    }

    public void OpenDoor()
    {
        _doorsOpen = true;
    }

    public void CloseDoor()
    {
        _doorsOpen = false;
    }

    public void MoveToFloor()
    {
        
        DisplayFloor();
        Console.WriteLine("What floor do you want to go to?");
        Console.Write("--> ");
        int entry = Console.ReadLine();
        if (entry > 1 && entry < 31)
        {
            DisplayFloor();
            OpenDoor();
        }
        else if (entry = 31)
        {
            Console.WriteLine("Please enter code.");
            Console.Write("-->");
            entry = Console.ReadLine();
            if (entry = "1234")
            {
                Console.WriteLine("Accepted");
                DisplayFloor();
                OpenDoor();
            }
            else
            {
                Console.WriteLine("Denied");
                Console.WriteLine("Calling security now...");
                CloseDoor();
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    public void DisplayFloor()
    {
        Console.WriteLine($"Floor: {_currentFloor}");
    }
}
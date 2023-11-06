using System.Diagnostics;
using System.Runtime.InteropServices;

public class Menu
{
    protected string _name;

    protected string _description;

    protected int _time;

    public Menu(string name, string description, int time)
    {
        _name = name;
        _description = description;
        _time = time;
    }

    public void TimerAnimation()
    {
        var stopwatch = DateTime.UtcNow;
        while (DateTime.UtcNow - stopwatch < TimeSpan.FromSeconds(_time))
        {
            Console.Write("+ ");            
            Console.Write("\b\b"); // Erase the + character
            Thread.Sleep(250);
            Console.Write("x "); // Replace it with the x character
            Console.Write("\b\b");
            Thread.Sleep(250);
        }


    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
    }

    public void EndingMessage()
    {
        Console.WriteLine("Thank you for using this program, good bye.");
    }

    public void SetTime()
    {
        Console.Write("Please enter how long you want the timer to run in seconds: ");
        _time = Int32.Parse(Console.ReadLine());
    }
}
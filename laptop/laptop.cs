public class Laptop {
    private double _screenSize;

    private string _os;

    private bool _touchScreen;

    public Laptop(double screenSize, string os, bool touchScreen) 
    {
        screenSize = _screenSize;
        os = _os;
        touchScreen = _touchScreen;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{_screenSize} {_os} {_touchScreen}");
    }
}
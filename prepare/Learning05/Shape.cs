using System.Security.Cryptography.X509Certificates;

public abstract class Shape
{
    protected string _color;

    //string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public void SetColor(string color)
    {
        //Console.WriteLine("What is the color?");
        //_color = Console.ReadLine();
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();
}
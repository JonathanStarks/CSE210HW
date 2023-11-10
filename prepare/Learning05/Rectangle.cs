public class Rectangle : Shape
{
    double _length;

    double _width;

    public Rectangle(double length, double width, string color) : base(color)
    {
        _length = length;
        _width = width;
        _color = color;
    }

    public override double GetArea()
    {
        //double area = _length * _width;
        //Console.WriteLine(area);
        //return base.GetArea();
        return _length * _width;
    }
}
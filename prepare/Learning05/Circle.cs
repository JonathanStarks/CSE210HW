public class Circle : Shape
{
    double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
        _color = color;
    }

    public override double GetArea()
    {
        //double area = 3.14 * (_radius * _radius);
        //Console.WriteLine(area);
        //return base.GetArea();
        return 3.14 * (_radius * _radius);
    }
}
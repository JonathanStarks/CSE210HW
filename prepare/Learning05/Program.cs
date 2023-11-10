using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Console.WriteLine("Hello Learning05 World!");
        Square isASquare = new Square(2, "Red");
        isASquare.GetColor();
        isASquare.GetArea();
        shapes.Add(isASquare);

        Circle isACircle = new Circle(3, "Green");
        isACircle.GetArea();
        isACircle.GetColor();
        shapes.Add(isACircle);

        Rectangle isARectangle = new Rectangle(5, 3, "blue");
        isARectangle.GetColor();
        isARectangle.GetArea();
        shapes.Add(isARectangle);
        
        foreach (Shape x in shapes)
        {
            string color = x.GetColor();
            double area = x.GetArea();
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Area: {area} units^2");
        }
    }
}
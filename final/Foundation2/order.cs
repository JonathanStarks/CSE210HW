using System.IO;
using System.Collections.Generic;
using System.Xml;

public class Order : Products
{
    public double _taxTotal;
    double _shipping;

    public Order(double shipping)
    {
        _shipping = shipping;
    }
    
    // This class will do calculations and handle displaying the information.
    // I want to have this method go through the baskets list and add all of the prices
    public void CalculateTotal()
    {
        AddToBasket();
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
        Console.WriteLine($"Total: ${System.Math.Round(_total, 2)}");
        _taxTotal = _total * 0.08;
        Console.WriteLine($"Tax: ${System.Math.Round(_total * 0.08, 2)}");
        Console.WriteLine($"Grand Total: ${System.Math.Round(_total + _taxTotal + _shipping, 2)}");
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
    }
}
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Xml;


public class Products
{
    protected double runningTotal;

    // This class will deal with the user adding things to their basket by adding it to a list that will be passed to the order class to be displayed
    int _howMany;
    bool _moreToOrder = true;
    int _itemNumber;
    protected double _total = 0.00;

    List<object> _productInfo = new List<object>
    {
        ("Bread", 2.50),
        ("1 lb Beef", 3.99),
        ("1 gal Gas", 4.01),
        ("T-Shirt", 19.99),
        ("Ductape", 7.99),
        ("Bike", 150.67),
        ("I-Phone", 999.99)
    };

    protected List<object> _basket = new List<object>();

    void ShowMerch()
    {
        int count = 1;
        Console.Clear();
        foreach (object x in _productInfo)
        {
            Console.WriteLine($"{count}. {x}");
            count ++;
        }
    }

    public void ItemsToBasket()
    {
        Console.WriteLine("What would you like to add to your basket?");
        Console.Write("Enter the number of the item: ");
        _itemNumber = System.Int32.Parse(Console.ReadLine()) - 1;
        Console.Write("How many of these do you want: ");
        _howMany = System.Int32.Parse(Console.ReadLine());
        while (_howMany > 0)
        {
            if (_itemNumber == 0)
            {
                _total = _total + 2.50;
            }
            else if (_itemNumber == 1)
            {
                _total = _total + 3.99;
            }
            else if (_itemNumber == 2)
            {
                _total = _total + 4.01;
            }
            else if (_itemNumber == 3)
            {
                _total = _total + 19.99;
            }
            else if (_itemNumber == 4)
            {
                _total = _total + 7.99;
            }
            else if (_itemNumber == 5)
            {
                _total = _total + 150.67;
            }
            else if (_itemNumber == 6)
            {
                _total = _total + 999.99;
            }
            else
            {
                Console.WriteLine("Error");
            }
            _basket.Add(_productInfo[_itemNumber]);
            _howMany --;
        }
    }
    public double AddToBasket()
    {
        // I want this to add the numebr of items and the item from productInfo to basket
        while (_moreToOrder == true)
        {
            Console.WriteLine("Would you like to add an item to your basket? Y/N");
            Console.Write("-> ");
            string response = Console.ReadLine();
            if (response == "Y" || response == "y")
            {
                ShowMerch();
                ItemsToBasket();
            }
            else
            {
                foreach (object x in _basket)
                {
                    Console.WriteLine(x);
                }
                _moreToOrder = false;
            }
        }
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
        return _total;
    }
}
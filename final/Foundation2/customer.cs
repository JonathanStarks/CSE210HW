public class Customer : Address
{
    // This class will deal with information about the user such as their name, payment info, and will check if the address is in the USA

    string _name;
    public static bool _inUSA;



    public Customer(string name, string address, string state, string country) :base (address, state, country)
    {
        _name = name;
    }
    public bool CheckCountry()
    {
        if (_country == "USA")
        {
            _inUSA = true;
        }
        else
        {
            _inUSA = false;
        }
        return _inUSA;
    }

    public void GreetCustomer()
    {
        Console.WriteLine($"Welcome, {_name}!");
    }

    public void ThankCustomer()
    {
        Console.WriteLine($"Thank you {_name}, for using our service!");
        Console.WriteLine("Have a great day!");
        Console.WriteLine("- - - - - - - - - - - - - - - - -");
    }
}
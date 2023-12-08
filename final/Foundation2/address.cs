public class Address
{
    protected string _address;
    protected string _state;
    protected string _country;

    public Address(string address, string state, string county)
    {
        _address = address;
        _state = state;
        _country = county;
    }
}
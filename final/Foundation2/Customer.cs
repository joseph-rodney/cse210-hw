public class Customer
{
    //Attributes
    public string _name;
    public Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool UsaOrNot()
    {
        return _address.UsaOrNot();
    }
}
public class Address
{
    //Attributes
    public string _street;
    public string _city;
    public string _state;
    public string _country;

    //Behavior
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
}
class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address (string street1, string city1, string state1, string country1)
    {
        _street = street1;
        _city = city1;
        _state = state1;
        _country = country1;
    }
    public bool USA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string Together()
    {
        string bunch = $"{_street}, {_city}, {_state}, {_country}";
        return bunch;
    }
}
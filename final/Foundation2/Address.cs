public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    public Address(string country)
    {
        _country = country;
    }
    public Address()
    {
    }

    public string GetStreet()
    {
        return _street;
    } 
    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }
    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public string DisplayAddress()
    {
        return $"Address:\n{_street},\n{_city} {_stateOrProvince},\n{_country}";
    }
    public bool IsInUSA()
    {
        if (_country == "USA")
            {
                return true;
            }
            return false;
    }
}

public class Custumer {
    private string _name;
    private List<Address> _address = new List<Address>();
    public Custumer(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    } 
    public void SetName(string name)
    {
        _name = name;
    }
    public List<Address> GetAddress()
    {
        return _address;
    }
    public void SetAddress(List<Address> address)
    {
        _address = address;
    }
    
    public string DisplayCustumer()
    {
        string output = "";
        for (int i=0;i <_address.Count; i++)
        {
            output += _address[i].DisplayAddress();
        }
        return $"Name: {_name}\n" + output;
    }
}
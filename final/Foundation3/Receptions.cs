
public class Receptions : Event
{
    private string _register;
    public Receptions(string register)
    : base()
    {
        _register = register;
    }
    
    public string GetRegister()
    {
        return _register;
    }
    public void SetRegister(string register)
    {
        _register = register;
    }

    public string GetReceptionsInformation()
    {
        return $"Type of Event Receptions \nMake your registration: {_register}";
    }
}
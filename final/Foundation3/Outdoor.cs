
public class Outdoor : Event
{
    private string _weather;
    public Outdoor(string weather)
    : base()
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }
    
    public string GetOutdoorInformation()
    {
        return $"\nWe have a day with a wather {_weather}";
    }
}
public class Activity
{
    private string _trackDate;
    private double _length;
    private double _distance;
    public Activity(string trackDate, double length, double distance)
    {
        _trackDate = trackDate;
        _length = length;
        _distance = distance;
    }
        public Activity(string trackDate, double length)
    {
        _trackDate = trackDate;
        _length = length;
    }

    public string GetTrackDate()
    {
        return _trackDate;
    }
    public void SetTrackDate(string trackDate)
    {
        _trackDate = trackDate;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetMLength(double length)
    {
        _length = length;
    }
    
    public virtual double ActivityDistance()
    {
        return 0;
    }
    public virtual double Speed()
    {
        return 0;
    }
    public virtual double Pace()
    {
        return _length / _distance;
    }
    public string GetSummary()
    {
        return $"{_trackDate} Running ({_length} min): Distance {ActivityDistance()} km, Speed: {Speed().ToString("N1")} kph, Pace: {Pace().ToString("N1")} min per km";
    }
}
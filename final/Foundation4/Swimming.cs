
public class Swimming : Activity
{
    private int _swimmingLaps;
    public Swimming(string trackDate, double length, int swimmingLaps)
    : base(trackDate, length)
    {
        _swimmingLaps = swimmingLaps;
    }

    public int GetSwimmingLaps()
    {
        return _swimmingLaps;
    }
    public void SetSwimmingLaps(int swimmingLaps)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double ActivityDistance()
    {
        double result = _swimmingLaps * 50.0 / 1000.0;
        return Math.Round(result, 1);
    }
    public override double Speed()
    {
        double result = (ActivityDistance() / GetLength()) * 60.0;
        return Math.Round(result, 1);
    }
    public override double Pace()
    {
        double result = GetLength() / ActivityDistance();
        return Math.Round(result, 1);
    }
}
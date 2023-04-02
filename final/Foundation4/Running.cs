
public class Running : Activity
{
    public Running(string trackDate, double length, double distance) : base(trackDate, length, distance){}

    public override double ActivityDistance()
    {
        return GetDistance();
    }
    public override double Speed()
    {
        return (GetDistance() / GetLength()) * 60.0;
    }
    public override double Pace()
    {
        return GetLength() / GetDistance();
    }
}
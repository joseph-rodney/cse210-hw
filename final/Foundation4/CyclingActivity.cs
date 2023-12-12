public class CyclingActivity : Activity
{
    // Attribute
    private double _speed;

    //Behavior
    public CyclingActivity(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_lengthInMinutes /60.0);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $", Speed: {_speed} mph, Distance: {GetDistance()} miles, Pace: {GetPace()} minutes/mile";
    }
}
public class RunningActivity : Activity
{
    //Attributes
    public double _distance;

    //Behavior
    public RunningActivity(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_lengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return _lengthInMinutes / _distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $", Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} minutes/mile";
    }
}
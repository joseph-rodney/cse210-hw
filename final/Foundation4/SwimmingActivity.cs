public class SwimmingActivity : Activity
{
    public int _lap;

    public SwimmingActivity(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _lap = laps;
    }

    public override double GetDistance()
    {
        // Assuming each lap is 25 meters
        return _lap * 25.0 / 1000.0; // Convert meters to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_lengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $", Laps: {_lap}, Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} minutes/km";
    }
}
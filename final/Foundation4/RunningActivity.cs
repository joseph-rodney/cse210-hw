public class RunningActivity : Activity
{
    public double Distance { get; set; }

    public RunningActivity(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / (LengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthInMinutes / Distance;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $", Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} minutes/mile";
    }
}
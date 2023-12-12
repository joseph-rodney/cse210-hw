public class Activity
{

    //Attributes
    public DateTime Date;
    public int LengthInMinutes;

    //Behavior
    public Activity(DateTime date, int lengthInMinutes)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return $"Date: {Date}, Length: {LengthInMinutes} minutes";
    }
}
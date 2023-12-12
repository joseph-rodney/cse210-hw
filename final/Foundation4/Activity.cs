public class Activity
{

    //Attributes
    public DateTime _date;
    public int _lengthInMinutes;

    //Behavior
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
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
        return $"Date: {_date}, Length: {_lengthInMinutes} minutes";
    }
}
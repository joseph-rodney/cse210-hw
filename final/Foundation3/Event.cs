public class Event
{
    //Attributes
    protected string _eventTitle;
    protected string _description;
    protected DateTime _date;
    protected TimeSpan _time;
    protected Address _venueAddress;
    
    //Behavior
    public Event(string eventTitle, string description, DateTime date, TimeSpan time, Address venueAddress)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _venueAddress = venueAddress;
    }

    public virtual string StandardDetails()
    {
    return $"Event: {_eventTitle}, Date: {_date}, Time: {_time}";
    }

    public virtual string FullDetails()
    {
        return $"Event: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nVenue: {_venueAddress}";
    }

    public virtual string ShortDescription()
    {
        return $"{_eventTitle} - {_description}";
    }

}
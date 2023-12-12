public class Reception: Event
{
    //Attributes
    private string _rsvpEmail;

    //Behavior
    public Reception(string rsvpEmail, string eventTitle, string description, DateTime date, TimeSpan time, Address venueAddress):base(eventTitle, description, date, time, venueAddress)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nRSVP Email: {_rsvpEmail}";
    }

}
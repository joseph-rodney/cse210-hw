public class Lectures: Event
{

    //Attributes
    private string _speaker;
    private int _capacity;

    public Lectures(string speaker, int capacity, string eventTitle, string description, DateTime date, TimeSpan time, Address venueAddress): base(eventTitle, description, date, time, venueAddress)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity} attendees.";
    }

}
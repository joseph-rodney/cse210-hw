public class OutdoorGathering:Event
{
    private string _weatherForecasting;

    public OutdoorGathering(string weatherForecasting, string eventTitle, string description, DateTime date, TimeSpan time, Address venueAddress): base(eventTitle, description, date, time, venueAddress)
    {
        _weatherForecasting = weatherForecasting;
    }

    public override string FullDetails()
    {
        return base.FullDetails() + $"\nWeather Forecast: {_weatherForecasting}";
    }
}
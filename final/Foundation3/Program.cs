using System;

class Program
{
    static void Main(string[] args)
    {
        //Create instances for the address
        Address address = new Address("123 Main Street", "Jinja City", "Jinja", "Uganda");
        Address address1 = new Address("Mwiri Street", "Jinja City", "Jinja", "Uganda");
        Address address2 = new Address("Kampala Street", "Kampala City", "Kampala", "Uganda");

        //Create intances for the three events
        Event lectureEvent = new Lectures("Kaneene Joseph",100,"Programming with Classes", "Design and Implement classes in C#", new DateTime(2023, 12, 15), new TimeSpan(18, 30, 0), address);
        Event receptionEvent = new Reception("kaneenerod@fusionframe.com", "C# BootCamp", "Learn Coding with C#", new DateTime(2023, 12, 20), new TimeSpan(19, 0, 0), address1);
        Event outdoorEvent = new OutdoorGathering("Cloudy", "The Cancer Marathon", "A running fundraiser", new DateTime(2023, 12, 23), new TimeSpan(12, 0, 0), address2);

        //Generate and Display messages
        //Lecture object
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine(lectureEvent.FullDetails());
        Console.WriteLine(lectureEvent.ShortDescription());

        //Reception Object
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine(receptionEvent.FullDetails());
        Console.WriteLine(receptionEvent.ShortDescription());

        //OutdoorGathering object
        Console.WriteLine(outdoorEvent.StandardDetails());
        Console.WriteLine(outdoorEvent.FullDetails());
        Console.WriteLine(outdoorEvent.ShortDescription());
    }
}

using System;

class Address
{
    private string street;
    private string city;
    private string state;
    private int zipCode;

    public Address(string street, string city, string state, int zipCode)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
    }

    public string GetAddress()
    {
        return $"{street}, {city}, {state} {zipCode}";
    }
}

abstract class Event
{
    private string title;
    private string description;
    private DateTime date;
    private Address address;

    public Event(string title, string description, DateTime date, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"{title}\n{description}\nDate: {date.ToShortDateString()}\nTime: {date.ToShortTimeString()}\nLocation: {address.GetAddress()}";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();
}

class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, Address address, string speaker, int capacity) 
        : base(title, description, date, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Lecture: {title}, {date.ToShortDateString()}";
    }
}

class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, Address address, string rsvpEmail) 
        : base(title, description, date, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Reception: {title}, {date.ToShortDateString()}";
    }
}

class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, Address address, string weatherForecast) 
        : base(title, description, date, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {title}, {date.ToShortDateString()}";
    }
}
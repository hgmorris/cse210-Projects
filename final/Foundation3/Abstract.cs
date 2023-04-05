using System;

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
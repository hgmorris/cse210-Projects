using System;

class Reception : Event
{
    private string rsvpEmail;
    private string title;
    private DateTime date;

    public Reception(string title, string description, DateTime date, Address address, string rsvpEmail) 
        : base(title, description, date, address)
    {
        this.rsvpEmail = rsvpEmail;
        this.title = title;
        this.date = date;
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

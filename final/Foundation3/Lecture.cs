using System;

class Lecture : Event
{
    private string speaker;
    private int capacity;
    private string title;
    private DateTime date;
    public Lecture(string title, string description, DateTime date, Address address, string speaker, int capacity) 
        : base(title, description, date, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
        this.title = title;
        this.date = date;

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

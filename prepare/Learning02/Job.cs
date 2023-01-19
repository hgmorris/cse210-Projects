class Resume
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Summary { get; set; }
    public List<JobHistory> JobHistories { get; set; }

    public Resume(string name, string email, string phoneNumber, string summary)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Summary = summary;
        JobHistories = new List<JobHistory>();
    }
}

class JobHistory
{
    public string Company { get; set; }
    public string Position { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }

    public JobHistory(string company, string position, DateTime startDate, DateTime endDate, string description)
    {
        Company = company;
        Position = position;
        StartDate = startDate;
        EndDate = endDate;
        Description = description;
    }
}

using System; 
public class Job
{ 
    public string _Job_Job_title;
    public string _Name_company;
    public int end_year;
    public int start_year;

    public void Display()
    {
        Console.WriteLine($"{_Job_Job_title} ({_Name_company}) {start_year}-{end_year}");
    }

}

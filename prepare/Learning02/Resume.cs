using System;
public class Resume
{
    public string _Name;

    public Resume(string _Name){
        this._Name=_Name;
    }

    public List<Job> _Jobs = new List<Job> ();
    public void Display()
    {
        Console.WriteLine($"Name: {_Name}");
        Console.WriteLine("Job: ");
        foreach (Job job in _Jobs)
        {
            job.Display();   
        }
    }
}
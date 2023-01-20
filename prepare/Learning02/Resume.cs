using System;
public class Resume
{
    public string _Name;

    public List<Job> _Jobs = new <Job> ();
    public void Display()
    {
        foreach (Job job in _Jobs)
        {
            job.Display();   
        }
    }
}
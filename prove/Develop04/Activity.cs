using System;

class Activity
{

    protected int _activityDuration;
    protected DateTime futureTime;

    
    public void ActivityBeginMessage(string activity, string description)
    {
        Console.WriteLine($"\nWelcome to the {activity} Activity.");
        Console.WriteLine(description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityDuration = Convert.ToInt32(Console.ReadLine());
    }

    public void ActivityEndMessage(string activity)
    {
        Console.WriteLine("\n\nWell done!");
        Animation(3);
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {activity} Activity.\n");
        Animation(3);
    }

    public void Animation(int addedTime)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        int i = 0;

        futureTime = DateTime.Now.AddSeconds(addedTime);
        while (DateTime.Now < futureTime)
        {
            string item = animationStrings[i];
            Console.Write(item);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}

using System;

class BreathingActivity : Activity
{    
    public void BreathingLoop()
    {
        Console.WriteLine("Get ready...");
        Animation(5);

        futureTime = DateTime.Now.AddSeconds(_activityDuration);
        while (DateTime.Now < futureTime) {
            Console.Write("Breathe in...  ");
            for(int i=5; i>0; i--) {
                Console.Write($"\b \b{i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\b \b");

            Console.Write("Breathe out...  ");
            for(int i=5; i>0; i--) {
                Console.Write($"\b \b{i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\b \b");
        }
    }
}
    


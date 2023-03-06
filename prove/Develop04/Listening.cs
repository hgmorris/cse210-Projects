using System;

class ListingActivity : Activity
{
    private string[] promptList = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void ListLoop()
    {
        // Opening Instructions
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000);

        Random random = new Random();
        int randomNumber = random.Next(0, promptList.Length);
        string selectedPrompt = promptList[randomNumber];

        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {selectedPrompt} ---");
        Console.Write("You may begin in:  ");
        for(int i=5; i>0; i--) {
            Console.Write($"\b \b{i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\b \b");

        // User input.
        int userCount = 0;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);
        
        while (startTime < futureTime) {
            Console.Write("> ");
            Console.ReadLine();
            userCount++;
            startTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {userCount} items!");


    }
}
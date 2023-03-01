using System;

class ReflectingActivity : Activity
{
    private string[] ponderMessageList = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] ponderQuestionList = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void ReflectingLoop()
    {
        Console.WriteLine("Get ready...");
        Animation(5);
        
        // Select Random Message from List.
        Random random = new Random();
        int randomNumber = random.Next(0, ponderMessageList.Length);
        string selectedPrompt = ponderMessageList[randomNumber];

        // Opening Instructions
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {selectedPrompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in:  ");
        for(int i=5; i>0; i--) {
            Console.Write($"\b \b{i}");
            Thread.Sleep(1000);
        }
        Console.Clear();

        // Ponder Questions
        DateTime futureTime2 = DateTime.Now.AddSeconds(_activityDuration);

        while (DateTime.Now < futureTime2) {
            randomNumber = random.Next(0, ponderQuestionList.Length);
            string selectedQuestion = ponderQuestionList[randomNumber];
            Console.Write(selectedQuestion + " ");
            Animation(10);
            Console.WriteLine();
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int menuChoice = 0;
        // Menu
        while (menuChoice != 4)
        {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\t1. Start Breathing Activity");
        Console.WriteLine("\t2. Start Reflecting Activity");
        Console.WriteLine("\t3. Start Listing Activity");
        Console.WriteLine("\t4. Quit");
        Console.Write("Select a choice from the menu: ");
        menuChoice = Convert.ToInt16(Console.ReadLine());

        if (menuChoice == 1) {
            // Activity Beginning Message
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.ActivityBeginMessage("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

            // Breathing Activity
            breathingActivity.BreathingLoop();

            // Activity End Message
            breathingActivity.ActivityEndMessage("Breathing");

        }

        if (menuChoice == 2) {
            // Activity Beginning Message
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            reflectingActivity.ActivityBeginMessage("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            // Reflecting Activity
            reflectingActivity.ReflectingLoop();

            // Activity End Message
            reflectingActivity.ActivityEndMessage("Reflecting");
        }

        if (menuChoice == 3) {
            // Activity Beginning Message
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.ActivityBeginMessage("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

            // Listing Activity
            listingActivity.ListLoop();

            // Activity End Message
            listingActivity.ActivityEndMessage("Listing");
        }
        }
        
        Console.WriteLine("Thank you for using the app!");        
    }
}
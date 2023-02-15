using System;

public class Program
{
    public static void Main(string[] args)
    {
        string testText = "For behold this is my work and my glory to bring "
            + "to pass the immortality and eternal life of  man.";
        Scripture scripture = new Scripture(testText);
        string reference = "Moses 1:39 ";

        string choice = "";
        while(choice != "quit")
        {
            
            // 1. show scripture
            Console.Clear();
            Console.Write(reference);
            string text = scripture.ToString();
            Console.WriteLine(text);

            // 2. wait for input
            choice = Console.ReadLine();

            // 3. if not quit hide a word
            if (choice != "quit" || choice != "restart")
            {
                scripture.RandomlyHideWord();
            }

            // 4. restore whole thing
            if (choice == "restart")
            {
                scripture.MakeAllWordsVisible();
            }
        }
    }
}


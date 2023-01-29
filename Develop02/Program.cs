// using System;
// using System.Collections.Generic;
// using System.IO;

// class Entry
// {
//     public string Prompt { get; set; }
//     public string Response { get; set; }
//     public DateTime Date { get; set; }

//     public Entry(string prompt, string response, DateTime date)
//     {
//         Prompt = prompt;
//         Response = response;
//         Date = date;
//     }
// }

// class Journal
// {
//     private List<Entry> entries;
//     private string fileName;

//     public Journal(string fileName)
//     {
//         this.fileName = fileName;
//         entries = new List<Entry>();
//     }

//     public void AddEntry(string prompt, string response)
//     {
//         Entry entry = new Entry(prompt, response, DateTime.Now);
//         entries.Add(entry);
//     }

//     public void DisplayEntries()
//     {
//         foreach (Entry entry in entries)
//         {
//             Console.WriteLine("Prompt: " + entry.Prompt);
//             Console.WriteLine("Response: " + entry.Response);
//             Console.WriteLine("Date: " + entry.Date);
//             Console.WriteLine();
//         }
//     }

//     public void SaveJournal()
//     {
//         using (StreamWriter writer = new StreamWriter(fileName))
//         {
//             foreach (Entry entry in entries)
//             {
//                 writer.WriteLine(entry.Prompt);
//                 writer.WriteLine(entry.Response);
//                 writer.WriteLine(entry.Date);
//             }
//         }
//     }

//     public void LoadJournal()
//     {
//         entries.Clear();
//         using (StreamReader reader = new StreamReader(fileName))
//         {
//             while (!reader.EndOfStream)
//             {
//                 string prompt = reader.ReadLine();
//                 string response = reader.ReadLine();
//                 DateTime date = Convert.ToDateTime(reader.ReadLine());
//                 Entry entry = new Entry(prompt, response, date);
//                 entries.Add(entry);
//             }
//         }
//     }
// }

// class Program
// {
//     static List<string> prompts = new List<string>()
//     {
//         "Who was the most interesting person I interacted with today?",
//         "What was the best part of my day?",
//         "How did I see the hand of the Lord in my life today?",
//         "What was the strongest emotion I felt today?",
//         "If I had one thing I could do over today, what would it be?"
//     }
//     static void Main(string[] args)
//     {
    
//         Journal journal = new Journal("journal.txt");
//         bool isrunning = true;
//         Console.Write("------Prompt Menu.-------------");
//         while (isrunning);
//         {
//             Console.WriteLine("Journal Options:");
//             Console.WriteLine("1. Write a new entry");
//             Console.WriteLine("2. Display journal");
//             Console.WriteLine("3. Save journal to a file");
//             Console.WriteLine("4. Load journal from a file");
//             Console.WriteLine("5. Exit");
//             Console.WriteLine();
//             Console.Write("Please select an option: ");

//             int choice = Convert.ToInt32(Console.ReadLine());
//         }
//     }
// }
// };
    

// //             switch (choice);
            

// //         }
// //                 case 1;
// //                     int index = new Random().Next(prompt);
// //         {

// //  }                


class Program
{
    static void Main()
    {
        int choice = 0;
        

        // Journal journal = new Journal("journal.txt");
        // bool isrunning = true;
        Console.WriteLine("------Prompt Menu.-------------");
        Console.WriteLine("");
        Console.WriteLine("Please select an option: ");
        Console.WriteLine();
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Save journal to a file");
        Console.WriteLine("4. Load journal from a file");
        Console.WriteLine("5. Exit");
        Console.Write("> ");
        

        
        List<string> notes = new List<string>();
        while (choice != 5)
        {
            //Console.WriteLine("Journal Options:");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Who was the most interesting person i interacted with today? ");

                string note = Console.ReadLine();
                notes.Add(note);
                foreach (string n in notes)
                    Console.WriteLine(n);
                ////Console.WriteLine(n);
            }

            if (choice == 2)
            {
                Console.WriteLine();
            }

            if (choice == 3)
            {
                Console.WriteLine();

            }
            if (choice == 4)
            {
                Console.WriteLine("4. Load journal from a file");
            }

            if (choice == 5)
            {
                System.Environment.Exit(0);
            }

        }

    }


};
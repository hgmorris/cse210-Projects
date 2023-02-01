using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }
}

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("----------------");
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.Date + "|" + entry.Prompt + "|" + entry.Response);
            }
        }
    }

    public void LoadJournal(string fileName)
    {
        entries.Clear();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    entries.Add(entry);
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Random rand = new Random();
        List<string> prompts = new List<string>();
        List<string> responses = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
    
        
        while (true)
        {
        
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice:");
       
             
            string[] choices = {"Write a new entry.", "Display the journal.", "Save the journal to a file.",
                             "Load the journal from a file", "Exit"};  
                
            
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (choice== 1)
            {
            int idx = rand.Next(prompts.Count);
            System.Console.WriteLine(prompts[idx]);
            string response = Console.ReadLine();
            responses.Add(response);
            System.Console.WriteLine(responses);
            foreach(string answer in responses)
            {
                System.Console.WriteLine("Response: " + answer);

            }


            }
            if(choice == 5)
            {
                System.Environment.Exit(0);
            }
            // {
            //     case 1:
            //     journal.writeEntry();
            //     break;
            //     case 2:
            //     // character = ''
            //     // strings = ""
            //     Console.WriteLine("AddEntry");
            //     // entries.Add(entry);
            //     break;
            //     case 3:
            //     // journal.Save();
            //     Console.WriteLine("SaveJournal");
            //     break;
            //     case 4:
            //     Console.WriteLine("SaveJournal");
            //     Load.Journal();
            //     break;
            //     case 5:
            //     Load.Journal();
            //     Console.WriteLine("LoadJournal");
            //     static void Main();
            // }
        }
    }    
        
}
                
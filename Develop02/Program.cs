using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string date;
    public string prompt;
    public string response;

    public Entry ()
    {
        DateTime dateTime = DateTime.Now;
        date = dateTime.ToShortDateString();
    }
}

class Journal
{
    public List<Entry> entries;

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
            Console.WriteLine("Date: " + entry.date);
            Console.WriteLine("Prompt: " + entry.prompt);
            Console.WriteLine("Response: " + entry.response);
            Console.WriteLine("----------------");
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.date + "|" + entry.prompt + "|" + entry.response);
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
                    Entry entry = new Entry();
                    entry.date = parts[0];
                    entry.prompt = parts[1];
                    entry.response = parts[2];
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
                Entry entry = new Entry();
                
                int idx = rand.Next(prompts.Count);
                System.Console.WriteLine(prompts[idx]);
                entry.prompt = prompts[idx];
                
                string response = Console.ReadLine();
                
                responses.Add(response);
                entry.response = response;
                journal.entries.Add(entry);

                
                foreach(string answer in responses)
                {
                    System.Console.WriteLine("Response: " + answer);
                }


            }
            else if(choice == 2){
                journal.DisplayJournal();

            }
            else if(choice == 3){
                Console.WriteLine("SaveJournal");
                string filename = Console.ReadLine();
                journal.SaveJournal(filename);

            }
            else if(choice == 4){
                Journal.LoadJournal();
                Console.WriteLine("LoadJournal");
                string filename = Console.ReadLine();
                journal.LoadJournal(filename);
            }
            else if(choice == 5)
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
                
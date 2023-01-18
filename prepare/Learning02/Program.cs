using System;



class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Hello  World!");

    }

}
class Job:
    def __init__(self, title, company, start_date, end_date, description):
        self.title = title
        self.company = company
        self.start_date = start_date
        self.end_date = end_date
        self.description = description

class Resume:
    def __init__(self, name, email, phone):
        self.name = name
        self.email = email
        self.phone = phone
        self.jobs = []

    def add_job(self, job):
        self.jobs.append(job);


using System;



class Program

{

    static void Main(string[] args)

    {
        Job Job1 = new Job();
        Job1._Job_Job_title="Web Developer";
        Job1._Name_company="Apple";
        Job1.start_year=2026;
        Job1.end_year=2030;
        
        Resume _MyResume=new Resume("Morris Hinneh");
        _MyResume._Jobs.Add(Job1);
       
        Job Job2 = new Job();
        Job2._Job_Job_title="Software engineer";
        Job2._Name_company="Tesla";
        Job2.start_year=2020;
        Job2.end_year=2024;
        
    
        _MyResume._Jobs.Add(Job2);
        _MyResume.Display();

    }

}
    
//     def __init__(self, title, company, start_date, end_date, description:
//         self.title = title
//         self.company = company
//         self.start_date = start_date
//         self.end_date = end_date
//         self.description = description

// class Resume:
//     def __init__(self, name, email, phone):
//         self.name = name
//         self.email = email
//         self.phone = phone
//         self.jobs = []

//     def add_job(self, job):
//         self.jobs.append(job);


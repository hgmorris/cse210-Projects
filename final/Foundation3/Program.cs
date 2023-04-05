using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", 12345);
        Address address2 = new Address("456 Oak Ave", "Sometown", "CA", 67890);
        Address address3 = new Address("789 Maple Blvd", "Othertown", "CA", 54321);

        Lecture lecture = new Lecture("The Future of Technology", "A discussion of emerging technologies", new DateTime(2023, 4, 15, 19, 0, 0), address1, "John Smith", 50);
        Reception reception = new Reception("Company Networking Event", "An opportunity to meet", new DateTime(2023, 4, 15, 19, 0, 0), address2, "hinnehmorris4@gmail.com");
       Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());

    }
 
 
}

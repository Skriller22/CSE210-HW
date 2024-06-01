using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Orem", "UT", "84097");
        Address address2 = new Address("456 Elm St", "Orem", "UT", "84097");
        Address address3 = new Address("789 Oak St", "Orem", "UT", "84097");

        ReceptionEvent reception = new ReceptionEvent("Wedding Reception", "A celebration of love", "10/10/2025", "6:00 PM", address1, "email@email.email");
        OutdoorEvent outdoor = new OutdoorEvent("Wedding Ceremony", "A celebration of love", "10/10/2025", "4:00 PM", address2, "Sunny");
        LectureEvent lecture = new LectureEvent("How to Program", "A lecture on programming", "11/11/2025", "2:00 PM", address3, "John Doe", 100);

        Console.WriteLine("--------------- Reception Details ---------------");
        Console.WriteLine("----- Full Details -----");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("----- Short Details -----");
        Console.WriteLine(reception.GetShortDetails());
        Console.WriteLine("----- Details -----");
        Console.WriteLine(reception.GetDetails());

        Console.WriteLine("--------------- Outdoor Details ---------------");
        Console.WriteLine("----- Full Details -----");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine("----- Short Details -----");
        Console.WriteLine(outdoor.GetShortDetails());
        Console.WriteLine("----- Details -----");
        Console.WriteLine(outdoor.GetDetails());

        Console.WriteLine("--------------- Lecture Details ---------------");
        Console.WriteLine("----- Full Details -----");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("----- Short Details -----");
        Console.WriteLine(lecture.GetShortDetails());
        Console.WriteLine("----- Details -----");
        Console.WriteLine(lecture.GetDetails());
    }
}

// Inheritance
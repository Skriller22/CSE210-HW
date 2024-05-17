using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Matthew Remington", "C# Programming");

        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Mandy Wilde", "Algebra", "2.2", "3-5");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("John Doe", "Narrative Writing", "My Summer Vacation");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
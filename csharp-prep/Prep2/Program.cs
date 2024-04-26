using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's find that letter grade!");

        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine());

        if (score >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (score >= 80)
        {
            Console.WriteLine("You got a B!");
        }
        else if (score >= 70)
        {
            Console.WriteLine("You got a C!");
        }
        else if (score >= 60)
        {
            Console.WriteLine("You got a D!");
        }
        else
        {
            Console.WriteLine("You got an F!");
        }
    }
}
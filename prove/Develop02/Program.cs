using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        journal.initialize();

        do
        {
            Console.WriteLine("---------- Main Menu ----------");
            Console.WriteLine("Please Select one of the following options:");
            Console.WriteLine("1. Write entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Change Load File");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    journal.WriteEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.ChangeLoadFile();
                    break;
                case 4:
                    journal.SaveToFile();
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (true);
    }
}
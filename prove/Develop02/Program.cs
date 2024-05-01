using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        promptGenerator promptGenerator = new promptGenerator();

        List<string> entries = new List<string>();

        Console.WriteLine("Journal Program");
        Console.WriteLine("Select a menu option by entering a number.");
        Console.Write("Please input name of Journal file (ex: journal.txt):");

        string loadFile = Console.ReadLine();

        do
        {
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
                    string prompt = promptGenerator.SelectRandomPrompt();
                    DateTime now = DateTime.Now;
                    string dateText = now.ToShortDateString();

                    Console.WriteLine($"{dateText} - Prompt: {prompt}");

                    string entry = Console.ReadLine();

                    string formattedEntry = $"Date: {dateText} Prompt: {prompt} \nEntry:\n{entry}\n";
                    entries.Add(formattedEntry);
                    break;
                case 2:
                    if (entries.Count > 0)
                    {
                        Console.WriteLine("Entries:");
                        foreach (string e in entries)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No entries found.");
                    }
                    break;
                case 3:
                    if (File.Exists("journal.txt"))
                    {
                        string[] loadedEntries = File.ReadAllLines("journal.txt");
                        entries.AddRange(loadedEntries);
                        Console.WriteLine("Entries loaded.");
                    }
                    else
                    {
                        Console.WriteLine("No entries found.");
                    
                    }
                    break;
                case 4:
                    File.WriteAllLines("journal.txt", entries);
                    Console.WriteLine("Entries saved.");
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
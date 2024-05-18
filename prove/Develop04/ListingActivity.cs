using System.Diagnostics;

public class ListingActivity : Activity
{
    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Duration = 60;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Start listing activity? (y/n)");
        string response = Console.ReadLine();
        if (response == "y") //Start the activity
        {
            Console.Clear();
            Console.WriteLine(GetRandomPrompt());
            List<string> list = GetListFromUser();
            DisplayEndingMessage();
        }
    }

    private string GetRandomPrompt()
    {
        string[] prompts = new string[]
        {
            "Who are the people in your life that you are grateful for?",
            "What are your personal strengths?",
            "Who have you helped this week?",
            "What are the things you are looking forward to?",
            "Who are some of your personal heroes?"
        };

        return prompts[new Random().Next(prompts.Length)];
    }

    private List<string> GetListFromUser()
    {
        Console.WriteLine($"Enter as many items as you can in the next {Duration} seconds");
        Console.WriteLine("Type 'done' if you are finished.");

        List<string> list = new List<string>();
        Stopwatch stopwatch = Stopwatch.StartNew();

        while (true)
        {
            string input = Console.ReadLine();

            if (stopwatch.Elapsed.TotalSeconds >= Duration)
            {
                Console.WriteLine("\nTime's up!");
                System.Threading.Thread.Sleep(1700);
                break;
            }

            if (input.ToLower() == "done")
            {
                break;
            }
            else if (string.IsNullOrWhiteSpace(input))
            {
                input = "Empty item";
            }
            else
            {
                list.Add(input);
            }
        }

        stopwatch.Stop();
        return list;
    }
}
public class ListingActivity : Activity
{
    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good thingsin your life by having you list as many things as you can in a certain area.";
        Duration = 5;
    }

    public void Run()
    {
        Console.WriteLine("Listing activity");
    }

    public string GetRandomPrompt()
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

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();

        Console.WriteLine($"Enter as many items as you can in the next {Duration} minutes.");
        Console.WriteLine("Type 'done' when you are finished.");

        string item = "";
        while (item != "done")
        {
            item = Console.ReadLine();
            if (item != "done")
            {
                list.Add(item);
            }
        }

        return list;
    }
}
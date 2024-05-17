public class Activity
{
    private string _name = "Activity";
    private string _description = "Activity";

    private int _duration = 5;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }

    public void ActivityStart()
    {
        Console.WriteLine($"Starting {_name} for {_duration} minutes");
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} for {_duration} minutes");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            System.Threading.Thread.Sleep(100);
            Console.Write("\b-");
            System.Threading.Thread.Sleep(100);
            Console.Write("\b\\");
            System.Threading.Thread.Sleep(100);
            Console.Write("\b|");
            System.Threading.Thread.Sleep(100);
            Console.Write("\b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
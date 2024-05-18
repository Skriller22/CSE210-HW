public class Activity
{
    private string _name = "Activity";
    private string _description = "Activity";

    private int _duration = 1;

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
        Console.Clear();
        Console.WriteLine($"Starting {_name}.");
        Console.WriteLine(_description);
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine(_name);
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine($"Ending {_name}");
        Console.WriteLine("Thank you for participating in this activity.");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b-");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b\\");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b|");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
        }
    }
    protected void ShowCountDown(int seconds) // Note: Ensure that all looped threading is equal to 1 second
    {
        for (int i = seconds; i > 0; i--)
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("<>");
            System.Threading.Thread.Sleep(500);
        }
    }
}
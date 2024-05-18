public class BreathingActivity : Activity
{
    private BreathAnimation breathAnimation = new BreathAnimation();
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = 
        "This activity is meant to help you center yourself by focusing on your breathing";
        Duration = 1;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Start the breathing activity? (y/n)");
        string response = Console.ReadLine();
        if (response == "y") //Start the activity
        {
            Console.WriteLine("\nHow long would you like to do this activity for? (in seconds)");
            double duration = Convert.ToInt32(Console.ReadLine());
            TimeSpan timeSpan = TimeSpan.FromSeconds(duration);

            Console.Clear();
            Console.WriteLine($"Take a moment to sit comfortably.");
            Console.WriteLine($"Press any key when you are ready to start.");
            Console.ReadKey();
            ShowSpinner(3);
            CycleBreathing(timeSpan);
            DisplayEndingMessage();
        }
        else //Return to menu
        {
            Console.WriteLine("Exiting...");
        }
    }

    private void CycleBreathing(TimeSpan duration)
    {
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        while (stopwatch.Elapsed < duration)
        {
            Console.Clear();
            PerformBreathingCycle();
        }
        stopwatch.Stop();
    }

    private void PerformBreathingCycle()
    {
        Console.WriteLine("Breathe in...");
        breathAnimation.BreathInBar(4);
        Console.WriteLine("Hold...");
        breathAnimation.BreathHoldBar(4);
        Console.WriteLine("Breathe out...");
        breathAnimation.BreatheOutBar(4);
        Console.WriteLine("Hold...");
        breathAnimation.BreathHoldBar(4);
    }
}
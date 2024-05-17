public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "Breathing in and out";
        Duration = 5;
    }

    public void Run()
    {
        Console.WriteLine("Breathing activity");
    }
}
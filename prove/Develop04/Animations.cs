public class Animation
{

}

public class BreathAnimation : Animation
{
    public void BreathInBar(int seconds)
    {
        PlayBreathAnimation(seconds, "<>");
        Console.WriteLine();
    }

    public void BreathHoldBar(int seconds)
    {
        PlayBreathAnimation(seconds, " = ");
        Console.WriteLine();
    }

    public void BreatheOutBar(int seconds)
    {
        PlayBreathAnimation(seconds, "<>");
        Console.WriteLine();
    }

    private void PlayBreathAnimation(int seconds, string symbol)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(symbol);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
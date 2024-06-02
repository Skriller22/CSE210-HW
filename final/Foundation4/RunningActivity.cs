public class RunningActivity : Activity
{
    public RunningActivity(DateTime Date, int Duration, double Distance)
    {
        this.Date = Date;
        this.Duration = Duration;

        this.Distance = Distance;
    }

    public override string GetSummary()
    {
        CalculateSpeed();
        CalculatePace();
        
        return $"{Date.ToShortDateString()} Running ({Duration})- Distance {Distance} mi, Speed: {Speed} mph, Pace: {Pace} min/mi";
    }
}
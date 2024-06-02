public class SwimmingActivity : Activity
{
    private int Laps { get; set; }

    public SwimmingActivity(DateTime dateTime, int Duration, int Laps)
    {
        this.Date = dateTime;
        this.Duration = Duration;

        this.Laps = Laps;
    }

    public override string GetSummary()
    {
        CalculateDistance();
        CalculatePace();
        CalculateSpeed();
        return $"{Date.ToShortDateString()} Swimming ({Duration})- Distance {Distance} mi, Speed: {Speed} mph, Pace: {Pace} min/mi";
    }

    public override void CalculateDistance()
    {
        Distance = Laps * 50 / 1000 * 0.62;
    }
}
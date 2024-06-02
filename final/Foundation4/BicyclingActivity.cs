public class ByciclingActivity : Activity
{
    public ByciclingActivity(DateTime Date, int Duration, double Speed)
    {
        this.Date = Date;
        this.Duration = Duration;
        this.Speed = Speed;
    }

    public override string GetSummary()
    {
        CalculateDistance();
        CalculatePace();
        return $"{Date.ToShortDateString()} Bicycling ({Duration})- Distance {Distance} mi, Speed: {Speed} mph, Pace: {Pace} min/mi";
    }

    public override void CalculateDistance()
    {
        Distance = Speed * Duration / 60;
    }
}
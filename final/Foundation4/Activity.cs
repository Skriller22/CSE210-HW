public abstract class Activity
{
    protected DateTime Date { get; set; }
    protected int Duration { get; set; }
    protected double Distance { get; set; }
    protected double Speed { get; set; }
    protected double Pace { get; set; }

    public virtual void CalculateSpeed()
    {
        Speed = Math.Round(Distance / Duration * 60, 2);
    }
    public virtual void CalculatePace()
    {
        Pace = Math.Round(Duration / Distance, 2);
    }
    public virtual void CalculateDistance()
    {
        Distance = Speed * Duration;
    }

    public abstract string GetSummary();
    // All calculations must be done in specific orders
}

// All duration is in minutes, distance is in miles, speed is in mph, and pace is in min/mi
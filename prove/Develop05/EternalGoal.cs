public class EternalGoal : Goal
{
    private bool _isComplete = false; 
    private int _timesCompleted;
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _timesCompleted = 0;
    }


    public override void RecordEvent()
    {
        // Record the event
        _points += _points;
        _timesCompleted++;
    }

    protected override bool IsComplete()
    {
        // Check if the goal is complete
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        // Get the details string
        return $"[{_timesCompleted}] {_shortName} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        // Get the string representation
        return $"{_shortName}|{_description}|{_points}|{_timesCompleted}";
    }

}
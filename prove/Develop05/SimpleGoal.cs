public class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }


    public override void RecordEvent()
    {
        // Record the event
        _isComplete = true;
    }

    protected override bool IsComplete()
    {
        // Check if the goal is complete
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // Get the string representation
        return $"{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
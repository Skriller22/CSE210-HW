public class CheckListGoal : Goal
{
    private int _target;
    private int _bonus;
    private bool _isComplete;
    private int _amountCompleted;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
        _isComplete = false;
    }


    public override void RecordEvent()
    {
        // Record the event
        _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            _isComplete = true;
        }
    }

    protected override bool IsComplete()
    {
        // Check if the goal is complete
        if (_amountCompleted == _target)
        {
            _isComplete = true;
            _points += _bonus;
        }
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        // Get the details string
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) --- Completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[] {_shortName} ({_description}) --- Currently Completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        // Get the string representation
        return $"{_shortName}|{_description}|{_points}|{_isComplete}|{_bonus}|{_amountCompleted}|{_target}";
    }
}
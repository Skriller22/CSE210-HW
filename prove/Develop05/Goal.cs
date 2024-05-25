public abstract class Goal
{
    public string _shortName;
    protected string _description;
    public int _points;

    public Goal(string name, string description, int points)
    {
        string _shortName = name;
        string _description = description;
        int _points = points;
    }

    public abstract void RecordEvent();
        // Record the event

    protected abstract bool IsComplete();
        // Check if the goal is complete

    public virtual string GetDetailsString()
    {
        // Retrun the details of the goal that could be shown in a list,
        // including the name, description, and points as well as a checkbox
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[] {_shortName} ({_description})";
        }
    }

    public abstract  string GetStringRepresentation();
        // Get the string representation for text file storage
}
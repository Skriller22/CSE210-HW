public class LectureEvent : Event
{
    public LectureEvent(string title, string description, string date, string time, Address address, string lecturer, int maxCapacity) : base(title, description, date, time, address)
    {
        Lecturer = lecturer;
        MaxCapacity = maxCapacity;
    }

    private string Type = "Lecture";
    private string Lecturer { get; set; }
    private int MaxCapacity { get; set; }

    public override string GetFullDetails()
    {
        return $"\nTitle: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nLecturer: {Lecturer}\nMax Capacity: {MaxCapacity}\nAddress: {Address.DisplayAddress()}\n";
    }

    public override string GetShortDetails()
    {
        return $"\nEvent Type: {Type}\nTitle: {Title}\nDate: {Date}\n";
    }
}
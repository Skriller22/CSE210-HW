public abstract class Event
{
    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    protected string Title { get; set; }
    protected string Description { get; set; }
    protected string Date { get; set; }
    protected string Time { get; set; }
    protected Address Address { get; set; }

    public virtual string GetDetails()
    {
        return $"\nTitle: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nAddress: {Address.DisplayAddress()}\n";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDetails();
}
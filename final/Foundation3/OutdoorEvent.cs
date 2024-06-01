public class OutdoorEvent : Event
{
    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    private string Type = "Outdoor";
    private string Weather { get; set; }

    public override string GetFullDetails()
    {
        return $"\nTitle: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nWeather: {Weather}\nAddress: {Address.DisplayAddress()}\n";
    }

    public override string GetShortDetails()
    {
        return $"\nEvent Type: {Type}\nTitle: {Title}\nDate: {Date}\n";
    }
}
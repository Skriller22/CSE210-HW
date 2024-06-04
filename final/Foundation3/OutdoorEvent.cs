public class OutdoorEvent : Event
{
    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        Weather = weather;
        Type = "Outdoor";
    }

    private string Weather { get; set; }

    public string GetFullDetails()
    {
        return $"\nTitle: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nWeather: {Weather}\nAddress: {Address.DisplayAddress()}\n";
    }
}
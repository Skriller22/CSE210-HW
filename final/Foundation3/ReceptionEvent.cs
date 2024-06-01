public class ReceptionEvent : Event
{
    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        Email = email;
    }

    private string Type = "Reception";
    private string Email { get; set; }

    public override string GetFullDetails()
    {
        return $"\nTitle: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nEmail: {Email}\nAddress: {Address.DisplayAddress()}\n";
    }

    public override string GetShortDetails()
    {
        return $"\nEvent Type: {Type}\nTitle: {Title}\nDate: {Date}\n";
    }
}
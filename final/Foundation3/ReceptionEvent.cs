public class ReceptionEvent : Event
{
    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        Email = email;
        Type = "Reception";
    }

    private string Email { get; set; }

    public string GetFullDetails()
    {
        return $"\nTitle: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nEmail: {Email}\nAddress: {Address.DisplayAddress()}\n";
    }

}
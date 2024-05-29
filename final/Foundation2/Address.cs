public class Address
{
    private string street { get; set; }
    private string city { get; set; }
    private string state { get; set; }
    private string zip { get; set; }
    private string Country { get; set; }

    public Address(string street, string city, string state, string zip, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
        Country = country;
    }

    public string GetAddress()
    {
        return $"{street}, \n{city}, {state}, {zip}, \n{Country}";
    }

    public bool IsUSAddress()
    {
        List<string> USA = new List<string> 
        { 
            "US", "USA", "UNITED STATES", "UNITED STATES OF AMERICA"
        };

        return USA.Contains(Country.ToUpper());
    }
}
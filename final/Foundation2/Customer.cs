public class Customer
{
    private string firstName { get; set; }
    private string lastName { get; set; }
    private Address address { get; set; }

    public Customer(string firstName, string lastName, Address address)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
    }

    public string DisplayCustomer()
    {
        return $"{firstName} {lastName} \n{address.GetAddress()}";
    }

    public bool IsUSCustomer()
    {
        return address.IsUSAddress();
    }

    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }
}
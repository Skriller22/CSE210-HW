public class Product
{
    private string name { get; set; }
    private string productID { get; set; }
    private double price { get; set; }
    private int quantity { get; set; }

    public Product(string name, string productID, double price, int quantity)
    {
        this.name = name;
        this.productID = productID;
        this.price = price;
        this.quantity = quantity;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"> {name} ({productID}) - ${price} (x{quantity})");
    }

    public double CalculateTotal()
    {
        return price * quantity;
    }
}
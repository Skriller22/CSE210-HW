public class Order
{
    private Customer customer { get; set; }
    private List<Product> products { get; set; }
    private double total { get; set; }

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
        total = CalculateOrderTotal();
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"{customer.DisplayCustomer()}");
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine(customer.GetFullName());
        foreach (Product product in products)
        {
            product.DisplayProduct();
        }
    }


    public void DisplayShippingPrice()
    {
        Console.WriteLine($"Shipping: ${CalculateShippingCost()}");
    }

    public void DisplayTax()
    {
        Console.WriteLine($"Tax: ${CalculateTax()}");
    }

    public void DisplayTotalPrice()
    {
        Console.WriteLine($"Total: ${total}");
    }


//Price Calcuations ----------------------------------------------
    private double CalculateSumPrice()
    {
        double sum = 0;
        foreach (Product product in products)
        {
            sum += product.CalculateTotal();
        }
        return sum;
    }

    private double CalculateShippingCost()
    {
        if (customer.IsUSCustomer())
        {
            return 5.00;
        }
        else
        {
            return 35.00;
        }
    }

    private double CalculateTax()
    {
        double tax = CalculateSumPrice() * 0.06;
        return Math.Round(tax, 2);
    }

    private double CalculateOrderTotal()
    {
        double total = CalculateSumPrice() + CalculateShippingCost() + CalculateTax();
        return Math.Round(total, 2);
    }
}
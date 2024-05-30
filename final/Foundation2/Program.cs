using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------- Order 1 --------------");
        Customer customer1 = new Customer("John", "Doe", new Address("123 Main St", "Anytown", "NY", "12345", "USA"));
        Order order1 = new Order(customer1, new List<Product>
        {
            new Product("Widget", "W123", 9.99, 4),
            new Product("Gadget", "G123", 19.99, 2)
        });

        Console.WriteLine("\nShippingLabel: ");
        order1.DisplayShippingLabel();

        Console.WriteLine("\nPackagingLabel: ");
        order1.DisplayPackingLabel();

        Console.WriteLine("\nTotal Price: ");
        order1.DisplayShippingPrice();
        order1.DisplayTax();
        order1.DisplayTotalPrice();


        Console.WriteLine("\n-------------- Order 2 --------------");
        Customer customer2 = new Customer("Jane", "Smith", new Address("456 Elm St", "Othertown", "ONTARIO", "54321", "CANADA"));
        Order order2 = new Order(customer2, new List<Product>
        {
            new Product("Widget", "W123", 9.99, 4),
            new Product("Gadget", "G123", 19.99, 2),
            new Product("Gizmo", "G321", 29.99, 1)
        });

        Console.WriteLine("\nShipping Label: ");
        order2.DisplayShippingLabel();

        Console.WriteLine("\nPackaging Label: ");
        order2.DisplayPackingLabel();

        Console.WriteLine("\nTotal Price: ");
        order2.DisplayShippingPrice();
        order2.DisplayTax();
        order2.DisplayTotalPrice();


        Console.WriteLine("\n-------------- Order 3 --------------");
        Customer customer3 = new Customer("Jared", "Hermano", new Address("123 Main St", "Anytown", "NY", "12345", "USA"));
        Order order3 = new Order(customer3, new List<Product>
        {
            new Product("Gizmo", "G321", 29.99, 1)
        });

        Console.WriteLine("\nShipping Label: ");
        order3.DisplayShippingLabel();

        Console.WriteLine("\nPackaging Label: ");
        order3.DisplayPackingLabel();

        Console.WriteLine("\nTotal Price: ");
        order3.DisplayShippingPrice();
        order3.DisplayTax();
        order3.DisplayTotalPrice();
    }
}

// Encapsulation and Online Ordering
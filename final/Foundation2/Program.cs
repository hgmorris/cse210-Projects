using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create two orders
        Order order1 = new Order("12345");
        order1.AddProduct("Apple", 1.0);
        order1.AddProduct("Banana", 2.0);
        order1.AddProduct("Orange", 3.0);

        Order order2 = new Order("67890");
        order2.AddProduct("Milk", 4.0);
        order2.AddProduct("Bread", 5.0);

        // display packing label, shipping label, and total price for each order
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label: " + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label: " + order1.GetShippingLabel());
        Console.WriteLine("Total Price: " + order1.GetTotalPrice());

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label: " + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label: " + order2.GetShippingLabel());
        Console.WriteLine("Total Price: " + order2.GetTotalPrice());
    }
}

class Order
{
    private string orderId;
    private List<Product> products;

    public Order(string orderId)
    {
        this.orderId = orderId;
        this.products = new List<Product>();
    }

    public void AddProduct(string name, double price)
    {
        Product product = new Product(name, price);
        this.products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "Order #" + this.orderId + "\n";
        foreach (Product product in this.products)
        {
            label += "- " + product.GetName() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Ship to:\n123 Main St.\nAnytown, USA\n";
    }

    public double GetTotalPrice()
    {
        double total = 0.0;
        foreach (Product product in this.products)
        {
            total += product.GetPrice();
        }
        return total;
    }
}

class Product
{
    private string name;
    private double price;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName()
    {
        return this.name;
    }

    public double GetPrice()
    {
        return this.price;
    }
}

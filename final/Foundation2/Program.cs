using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create two customers
        Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address nonUsaAddress = new Address("456 Main St", "Anycity", "ON", "Canada");

        Customer usaCustomer = new Customer("Morris Hinneh", usaAddress);
        Customer nonUsaCustomer = new Customer("Augustine Donyen", nonUsaAddress);

        // Create some products
        Product product1 = new Product("Product 1", "P1", 10.0, 2);
        Product product2 = new Product("Product 2", "P2", 15.0, 1);
        Product product3 = new Product("Product 3", "P3", 5.0, 3);

        // Create two orders
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(nonUsaCustomer);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display packing and shipping labels, and total prices for each order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total price: $" + order1.GetTotalPrice());

        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total price: $" + order2.GetTotalPrice());
    }
}

// class Program
// {
//     static void Main(string[] args)
//     {
//         // create an order for a customer in the USA
//         Address usaAddress = new Address("123 Main St", "Anytown", "NY", "USA");
//         Customer usaCustomer = new Customer("John Smith", usaAddress);
//         List<Product> usaProducts = new List<Product>();
//         usaProducts.Add(new Product("Product A", "A123", 10.99m, 2));
//         usaProducts.Add(new Product("Product B", "B456", 15.99m, 1));
//         Order usaOrder = new Order(usaProducts, usaCustomer);

//         // create an order for a customer outside the USA
//         Address intAddress = new Address("456 High St", "Anycity", "Province A", "Canada");
//         Customer intCustomer = new Customer("Jane Doe", intAddress);
//         List<Product> intProducts = new List<Product>();
//         intProducts.Add(new Product("Product C", "C789", 20.99m, 3));
//         intProducts.Add(new Product("Product D", "D012", 8.99m, 4));
//         intProducts.Add(new Product("Product E", "E345", 5.99m, 2));
//         // Order intOrder =
//     } 
// }
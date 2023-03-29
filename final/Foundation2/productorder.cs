using System;
using System.Collections.Generic;

public class Product {
    private string name;
    private int id;
    private double price;
    private int quantity;

    public Product(string name, int id, double price, int quantity) {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name { get { return name; } }
    public int ID { get { return id; } }
    public double Price { get { return price; } }
    public int Quantity { get { return quantity; } }

    public double TotalPrice { get { return price * quantity; } }
}

public class Address {
    private string street;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string street, string city, string stateProvince, string country) {
        this.street = street;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public string Street { get { return street; } }
    public string City { get { return city; } }
    public string StateProvince { get { return stateProvince; } }
    public string Country { get { return country; } }

    public bool IsInUSA() {
        return country == "USA";
    }

    public string GetAddressString() {
        return street + "\n" + city + ", " + stateProvince + "\n" + country;
    }
}

public class Customer {
    private string name;
    private Address address;

    public Customer(string name, Address address) {
        this.name = name;
        this.address = address;
    }

    public string Name { get { return name; } }
    public Address Address { get { return address; } }

    public bool IsInUSA() {
        return address.IsInUSA();
    }
}

public class Order {
    private Customer customer;
    private Product[] products;
    private double shippingCost;

    public Order(Customer customer, Product[] products) {
        this.customer = customer;
        this.products = products;

        if (customer.IsInUSA()) {
            shippingCost = 5;
        } else {
            shippingCost = 35;
        }
    }

    public Customer Customer { get { return customer; } }
    public Product[] Products { get { return products; } }
    public double ShippingCost { get { return shippingCost; } }

    public double TotalPrice {
        get {
            double totalPrice = shippingCost;
            foreach (Product product in products) {
                totalPrice += product.TotalPrice;
            }
            return totalPrice;
        }
    }

    public string GetPackingLabel() {
        string packingLabel = "";
        foreach (Product product in products) {
            packingLabel += product.Name + ", ID: " + product.ID + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel() {
        Customer customer = this.customer;
        string shippingLabel = customer.Name + "\n" + customer.Address.GetAddressString();
        return shippingLabel;
    }
}
class Program {
    static void Main(string[] args) {
        // create two products
        Product product1 = new Product("Product 1", 1, 10, 2);
        Product product2 = new Product("Product 2", 2, 20, 1);

        // create two customers with addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("Customer 1", address1);

        Address address2 = new Address("456 Second St", "Othertown");{


        }

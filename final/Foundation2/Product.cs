using System;


class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetPrice()
    {
        return price * quantity;
    }
    public string GetPackingLabel()
    {
        return $"Packing Label:\n{name} ({productId})";
    }
    public string GetName()
    {
        return name;
    }
    public string GetId()
    {
        return productId;
    }
}
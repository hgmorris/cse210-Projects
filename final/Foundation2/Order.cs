
using System;



class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        this.products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0.0;

        foreach (Product product in this.products)
        {
            totalPrice += product.GetPrice();
        }

        if (this.customer.IsInUsa())
        {
            totalPrice += 5.0;
        }
        else
        {
            totalPrice += 35.0;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in this.products)
        {
            packingLabel += product.GetName() + " - " + product.GetId() + "\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return this.customer.GetName() + "\n" + this.customer.GetAddress().ToString();
    }
   
}
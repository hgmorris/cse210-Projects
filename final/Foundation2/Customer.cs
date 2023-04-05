
using System;


class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUsa()
    {
        return address.IsInUsa();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{name}\n{address.GetAddressString()}";
    }
     public string GetName()
    {
        return name;
    }
     public Address GetAddress()
    {
        return address;
    }
}
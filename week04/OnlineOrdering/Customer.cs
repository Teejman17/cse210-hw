using System;
using System.Collections.Generic;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public string GetName()
    {
        return _customerName;
    }

    public Address GetAddress()
    {
        return _customerAddress;
    }

    public bool Country()
    {
        return _customerAddress.nationalAddress();
    }

}
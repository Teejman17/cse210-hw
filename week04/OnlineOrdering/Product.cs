using System;
using System.Collections.Generic;

public class Products
{
    private string _name;

    private string _productId;
    private double _price;

    private int _quantity;

    public Products(string name, string productsId, double price, int quantity)

    {
        _name = name;
        _productId = productsId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double TotalCost()
    {
        return _price * _quantity;
    }

}
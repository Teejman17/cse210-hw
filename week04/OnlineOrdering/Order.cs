using System;
using System.Collections.Generic;
using System.Reflection.Emit;

public class Order
{
    private List<Products> _products;
    private Customer _customer;
    private double _nationalShippingCost;
    private double _internationalShippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Products>();
        _nationalShippingCost = 5.00;
        _internationalShippingCost = 35.00;
    }

    public double TotalOrderCost()
    {
        double productsTotal = 0;
        foreach (var product in _products)
        {
            productsTotal += product.TotalCost();
        }

        double shippingCost = 0;

        if (_customer.Country())
        {
            shippingCost = _nationalShippingCost;
        }
        else
        {
            shippingCost = _internationalShippingCost;
        }
        return productsTotal + shippingCost;
    }
    public string packingLabel()
    {
        string label = "";
        foreach (Products product in _products)
        {
            label += $"Product: {product.GetName()},   Product ID: {product.GetProductId()}";

        }
        return label;
    }

    public string shippingLabel()
    {
        string label = $"Customer: {_customer.GetName()},   Address: {_customer.GetAddress().FullAddress()}";
        return label;        
    }

}

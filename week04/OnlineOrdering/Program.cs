using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("street 123", "first city", "Utah", "USA");
        Address address2 = new Address("Batcave Wayne Mansion", "Gotham City", "New Jersey", "USA");
        Address address3 = new Address("Calle 123", "Monterrey", "Nuevo Leon", "Mexico");

        Customer customer1 = new Customer("GI Joe", address1);
        Customer customer2 = new Customer("Bruce Wayne", address2);
        Customer customer3 = new Customer("Pancho Villa", address3);

        Products tv = new Products("Samsung 65in", "SAM65TV", 599.99, 2);
        Products coffeeTable = new Products("Coffee Table", "COFTAB", 299.95, 1);
        Products dryer = new Products("LG Touch", "LGDRY", 815.00, 1);
        Products golfClubs = new Products("Callaway complete set", "CALGOLF", 1500.00, 1);
        Products motorcycle = new Products("2024 Honda Rebel", "24HONREB", 6500.00, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(motorcycle);

        Order order2 = new Order(customer2);
        order2.AddProduct(golfClubs);
        order2.AddProduct(tv);
        order2.AddProduct(coffeeTable);
        order2.AddProduct(dryer);
        order2.AddProduct(motorcycle);

        Order order3 = new Order(customer3);
        order3.AddProduct(tv);
        order3.AddProduct(coffeeTable);

        Console.WriteLine(order1.packingLabel());
        Console.WriteLine(order1.shippingLabel());
        Console.WriteLine($"Order total cost: {order1.TotalOrderCost():F2}");

        Console.WriteLine(new string('-', 150));

        Console.WriteLine(order2.packingLabel());
        Console.WriteLine(order2.shippingLabel());
        Console.WriteLine($"Order total cost: {order2.TotalOrderCost():F2}");

        Console.WriteLine(new string ('-', 150));

        Console.WriteLine(order3.packingLabel());
        Console.WriteLine(order3.shippingLabel());
        Console.WriteLine($"Order total cost: {order3.TotalOrderCost():F2}");

    }
}
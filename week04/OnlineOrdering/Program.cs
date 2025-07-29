using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("street 123", "first city", "UT", "USA");
        Address address2 = new Address("123 street", "City 1st", "TX", "USA");
        Address address3 = new Address("Calle 123", "Monterrey", "Nuevo Leon", "Mexico");

        Customer customer1 = new Customer("GI Joe", address1);
        Customer customer2 = new Customer("Bruce Wayne", address2);
        Customer customer3 = new Customer("Pancho Villa", address3);

        

    }
}
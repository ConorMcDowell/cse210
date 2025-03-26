using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the customer's name? ");
        string customername = Console.ReadLine();
        Console.Write("What is the customer's street? ");
        string street = Console.ReadLine();
        Console.Write("What is the customer's city? ");
        string city = Console.ReadLine();
        Console.Write("What is the customer's state/province? ");
        string state = Console.ReadLine();
        Console.Write("What is the customer's country? ");
        string country = Console.ReadLine();
        
        Customer customer1 = new Customer(customername);
        Address address1 = new Address(street, city, state, country);

        Console.Write("How many distinct products did they order? ");
        int quantity = int.Parse(Console.ReadLine());

        Order order1 = new Order();
        order1.AddProduct(quantity);

        order1.PackLabel();
        order1.ShipLabel(customer1, address1.Together());
        order1.TotPrice(address1.USA());
    }
}
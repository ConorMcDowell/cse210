using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations.Schema;

class Order
{
    List<Product> products = new List<Product>();
    public void TotPrice(bool murica)
    {
        float cost = 0;
        
        foreach (Product product in products)
        {
            cost += product.Total();
        }

        float tot = 0;
        if (murica == true)
        {
            tot = cost + 5;
        }
        else
        {
            tot = cost + 35;
        }
        Console.WriteLine($"Total: \n${tot}");
    }
    public void AddProduct(int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            Console.Write("What is the name of this product? ");
            string productname = Console.ReadLine();
            Console.Write("What is the product id of this product? ");
            string id = Console.ReadLine();
            Console.Write("How much does this product cost? ");
            float cost = float.Parse(Console.ReadLine());
            Console.Write("How many of this product did they order? ");
            int count = int.Parse(Console.ReadLine());
            Product product1 = new Product(productname, id, cost, count);
            products.Add(product1);
        }
    }
    public void PackLabel()
    {
        Console.WriteLine("Packing Label: ");
        foreach (Product product in products)
        {
            string productname = product.GetName();
            string productid = product.GetID();
            Console.WriteLine($"{productname} {productid}");
        }
    }
    public void ShipLabel(Customer customer1, string address1)
    {
        string name = customer1.GetName();
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"{name} {address1}");
    }
}
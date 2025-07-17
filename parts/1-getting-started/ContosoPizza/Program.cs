using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new();

var products = context.Products
                    .Where(p => p.Price > 10.00M)
                    .OrderBy(p => p.Name);


foreach (Product p in products)
{
    Console.WriteLine($"Id:    {p.Id}");
    Console.WriteLine($"Name:  {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}
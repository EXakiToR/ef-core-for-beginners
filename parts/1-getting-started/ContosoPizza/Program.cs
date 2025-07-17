using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new();

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;


foreach (Product p in products)
{
    Console.WriteLine($"Id:    {p.Id}");
    Console.WriteLine($"Name:  {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}
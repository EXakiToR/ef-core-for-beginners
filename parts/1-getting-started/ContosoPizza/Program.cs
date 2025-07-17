using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new();

var products = from product in context.Products
               where product.Price > 10.00M
               orderby product.Name
               select product;

var veggieSpecial = context.Products
                       .Where(p => p.Name == "Veggie Special Pizza")
                       .FirstOrDefault();


if (veggieSpecial is Product)
{
    veggieSpecial.Price = 10.99M;
}

if (veggieSpecial is not null)
{
    context.Remove(veggieSpecial);
}

foreach (Product p in products)
{
    Console.WriteLine($"Id:    {p.Id}");
    Console.WriteLine($"Name:  {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}

context.SaveChanges();
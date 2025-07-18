using ContosoPizza.Data;
using ContosoPizza.Models;

public class Program
{
    public static void Main(string[] args)
    {


        using ContosoPizzaContext context = new ContosoPizzaContext();

        foreach (Customer c in context.Customers)
        {
            Console.WriteLine($"Name: {c.FirstLast}");
        }
    }
}
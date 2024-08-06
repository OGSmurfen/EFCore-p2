using ContosoPizza.Models;

using ContosoPizza.Data;



using ContosoPizzaPart1Context context = new ContosoPizzaPart1Context();

foreach(Customer customer in context.Customers)
{
    Console.WriteLine($"Name: {customer.FirstLast}");
}




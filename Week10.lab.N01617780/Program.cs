using System;
using Week10.lab.N01617780.Models.Entities;
class program
{
    public static void Main(string[] args)
    {
        using(var context = new MMABooksContext())
        {
            var customers = context.Customers;
            foreach(var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace ConstructorPlay
{
    public class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "abel";
            
            var order = new Order();
            customer.Order.Add(order);
            
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine();
        }
    }
}
using System;

namespace ConstructorPlay
{
    public class Customer
    {
        public String Name;
        public Customer(string play)
        {
            this.Name = play;
        }
        static void Main(string[] args)
        {
            var play = new Customer("abel");
            Console.WriteLine(play);
        }
    }
}
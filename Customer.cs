using System;

namespace ConstructorPlay
{
    public class Customer
    {
        public int Id;
        public string Name;
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
using System.Collections.Generic;

namespace ConstructorPlay
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order>Order;

        public Customer()
        {
           Order = new List<Order>();
        }

        public Customer(int id)
        //loads the no-default constructor first 
        :this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        :this(id)
        {
            this.Name = name;
        }
    }
}
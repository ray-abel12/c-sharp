using System;

namespace MoreWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string conditionInput = "";
            int total = 0;
            int additionInput = 0;
            while (conditionInput !="ok")
            {
                Console.WriteLine("enter number ");
                var j = Console.ReadLine();
                additionInput = Convert.ToInt32(j);
               
                    total = total + additionInput; 
                

                Console.WriteLine("enter 'ok' to  end and sum numbers ");
                var i = Console.ReadLine();
                conditionInput = Convert.ToString(i);
               
            }
            Console.WriteLine($"the final value is {total}");
        }
    }
}

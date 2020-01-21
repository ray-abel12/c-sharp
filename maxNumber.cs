using System;

namespace MaximumValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two values");
            var value1 = Console.ReadLine();
            var value2 = Console.ReadLine();

            var intA = Convert.ToInt32(value1);
            var intB = Convert.ToInt32(value2);

           
            if (intA > intB)
            {
                Console.WriteLine($"{intA} is the maximum");
            }
            else
            {
                Console.WriteLine($"{intB} is the maximum ");
            }

        }
    }
}

using System;
using System.Collections.Generic;

namespace uniqueValue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>number = new List<int>();
            while (true)
            {
                Console.WriteLine("enter numbers and type quite to end");
                var input = Console.ReadLine();
                
                if (input.ToLower() == "quit")
                {
                    break;
                }

                number.Add(Convert.ToInt32(input));
            }
            
            var unqiue =new List<int>();
            
            foreach (var index in number)
            {
               if(!unqiue.Contains(index))
                   unqiue.Add(index);
            }

            Console.WriteLine("unique numbers");
            foreach (var value in unqiue)
            {
                Console.WriteLine("unqiue value "+ value);
            }
        }
    }
}
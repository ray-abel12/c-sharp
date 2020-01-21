using System;

namespace numberValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number from 1 - 10");
           
          var input =Console.ReadLine();
          var result = Convert.ToInt32(input);
          if (result >= 1 && result <= 10)
          {
              Console.WriteLine("values are within the range of 1-10");
            }
          else
          {
              Console.WriteLine("out of range/invalid character");
          }

        }
    }
}

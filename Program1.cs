using System;
using System.ComponentModel.Design;

namespace conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Winter;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("it is autumn");
                    break;
                case Season.Spring:
                    Console.WriteLine("it is spring");
                    break;
                case Season.Summer:
                    Console.WriteLine("it is summer");
                    break;
                case Season.Winter:
                    Console.WriteLine("it is winter");
                    break;
                default:
                    Console.WriteLine("no session selected");
                    break;
            }
          //  Console.WriteLine((int)result);
           // int hour = 12;
          //  if (hour > 0 && hour < 12)
           // {
           //     Console.WriteLine("its morning");
          //  }else if (hour >= 12 && hour < 18)
          //  {
           //     Console.WriteLine("its afternoon");
          //  }
          //  else
           // {
           //     Console.WriteLine("its night time");
          //  }
            //another
            bool isCustomerGold = true;
           // float price;
          //  if (isCustomerGold)
           //   Console.WriteLine(price = 19.99f); 
          //  else
          //  {
          //     Console.WriteLine(price = 29.99f); 
          //  }

          //  float price = (isCustomerGold) ? 19.32f : 29.5f;
          //  Console.WriteLine($"the float price is {price}");
        }
    }
}

using System;

namespace ConsoleApp3
{
  public  class Program
    {
     public static void Main(string[] args)
     {
         Int16 a = 10;
         Int16 b = 12;
         Int16 c = 10;

            Console.WriteLine(a < c || b > a);
            Console.WriteLine((a < c) | (b > a));
            Console.WriteLine("addition "+ (a+b));
          
        }
    }
}

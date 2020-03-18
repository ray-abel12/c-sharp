using System;

namespace String
{
   public class String
    {
        static void Main(string[] args)
        {
            var fullName = "abel ray ";
            Console.WriteLine($"trim {fullName.Trim()}");
            Console.WriteLine($"trim and toupper {fullName.Trim().ToUpper()}");

            //split it back
            var name = fullName.Split(' ');
            Console.WriteLine("firstName " + name[0]);
            Console.WriteLine("lastName " + name[1]);
         var replace = fullName.Replace("ray", "obeya");
         Console.WriteLine(replace);
         Console.WriteLine("it works ");
        }
    }
}

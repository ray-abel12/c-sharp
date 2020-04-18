using System;
using System.Runtime.InteropServices;

namespace ValidDateTime
{
    class ValidTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a valid time between 00:00 to 23:59");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            var time = Convert.ToDouble(input);
            try
            {
            if((time >00.00) &&(time<23.59))
            {
                Console.WriteLine("valid time");
            }
            else
            {
                Console.WriteLine("invalid time");
            }
            }
            catch (Exception e)
            {
                Console.WriteLine("invalid time");
                throw;
            }

        }
    }
}
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

            var isValid = isTimeValid(input);
            var message = isValid ? "valid Time" : "Invalid Time";
            Console.WriteLine(message);
        }

        public static bool isTimeValid(string input)
        {
            var isValid = false;
            var time = Convert.ToDouble(input);
            try
            {
                if((time >00.00) &&(time<23.59))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            catch (Exception e)
            {
                isValid = false;
                throw;
            }

            return isValid;
        }
    }
}
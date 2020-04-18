using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace StringDublicate
{
    class StringDublicate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter values i.e(1-2-3-4)");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            var number = new List<int>();
            foreach (var numbers in input.Split('-'))
            {
                number.Add(Convert.ToInt32(numbers));
            }

            var unique = new List<int>();
            var isDuplicate = false;
            foreach (var numbers in number)
            {
                if (!unique.Contains(numbers))
                {
                    unique.Add(numbers);
                }
                else
                {
                    isDuplicate = true;
                    break;
                }
            }

            var message = isDuplicate ? "Yes There is Duplicate" : "No Duplicate found";
            Console.WriteLine(message);
        }
    }
}

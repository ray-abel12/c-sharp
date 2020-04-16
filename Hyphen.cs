using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Hypen_Numbers
{
    class Hyphen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number seperated by hypen");
            var userInput = Console.ReadLine();
            var numbers = userInput.Split('-').Select(text => Convert.ToInt32(text));
            var numberList = new List<int>();
            
            foreach (var index in numbers)
            {
               numberList.Add(index);
            }

            var temp = numberList[0] - numberList[1];
            
            if((temp == 1) || (temp == -1)
            {
                Console.WriteLine("");
            }

        }
    }
}
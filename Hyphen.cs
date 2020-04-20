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
            var numberList = new List<int>();
            var isConsecutive = GetNumbers(userInput, numberList);
            var isConsective = isConsecutive ? "Consecutive" : "Not Consective";
            Console.WriteLine(isConsective);
        }

        public static bool  GetNumbers(string userInput, List<int> numberList)
        {
            var numbers = userInput.Split('-').Select(text => Convert.ToInt32(text));
            var isConsecutive = false;
            foreach (var index in numbers)
            {
                numberList.Add(Convert.ToInt32(index));
            }

            var temp = numberList[0] - numberList[1];
            
            if((temp == 1) || (temp == -1))
            {
                isConsecutive = true;
            }else
            {
                isConsecutive = false;
            }

            return isConsecutive;
        }
    }
}
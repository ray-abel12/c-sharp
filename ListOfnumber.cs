using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',');
            var value = 0;

            foreach (var index in input)
       {
           var result = Convert.ToInt32(index);
           var resultList = new List<int>();
           resultList.Add(result);
           value =  resultList.Max();
           
            }
       Console.WriteLine(value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ListOfCommaSeperatedNumbers
{
    class CommaSeperatedNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter nos seperated by commas");
            string[] elements;
             elements = Console.ReadLine().Split(",");

             var nameList = GetNumbers(elements);
             Console.WriteLine("smallest ={0} followed by ={1} then = {2}",nameList[0],nameList[1],nameList[2]);
             Console.WriteLine(DateTime.Now);
          
        }

        public static List<int> GetNumbers(string[] elements)
        {
            var nameList = new List<int>();
            foreach (var index in elements)
            {
                nameList.Add(Convert.ToInt32(index));
            }
            nameList.Sort();
            return nameList;
        }

        

    }
}
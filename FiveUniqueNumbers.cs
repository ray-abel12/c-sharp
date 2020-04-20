using System;
using System.Collections.Generic;

namespace FiveUniqueNumbers
{
    class FiveUniqueNumbers
    {
        static void Main(string[] args)
        {


            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("enter 5 numbers ");
                Console.WriteLine("numbers stored " + numbers.Count);
                var input = Console.ReadLine();
                if (CheckForUnique(numbers, input).Equals(true))
                {
                    Console.WriteLine("try again");
                    continue;
                }
                numbers.Add(Convert.ToInt32(input));
                
               
                numbers.Sort();
                foreach (var index in numbers)
                {
                    Console.Write(index);
                }
                if(numbers.Count == 5)
                    break;
            }
        }

        public static bool CheckForUnique(List<int> numbers,string input)
        {
           
                 
                if (numbers.Contains(Convert.ToInt32(input)))
                {
                    return true;
                }

                return false;

        }
           
           
        }
    }

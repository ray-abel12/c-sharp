using System;
using System.Collections.Generic;

namespace List
{
    class List
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {1, 2, 1, 4, 5};

            //can only add a single number at a time
            numbers.Add(12);

            //can add multiple values including using an array or list
            numbers.AddRange(new int[4]{10,12,1,14});
            numbers.AddRange(new List<int>(){200,300,400});
            foreach (var index in numbers)
            {
                Console.WriteLine(" the integer list values are: "+index);
            }

            //indexof
            Console.WriteLine("indexof");
            Console.WriteLine(numbers.IndexOf(5));

            //lastindexof
            Console.WriteLine("lastindexof");
            Console.WriteLine(numbers.LastIndexOf(5));

            //count
            Console.WriteLine("count");
            Console.WriteLine(numbers.Count);

            //remove from the list
            Console.WriteLine("remove from the list");
            for (var i = 0; i< numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var index in numbers)
            {
                Console.WriteLine(index);
            }
            {
                
            }
            
        }
    }
}

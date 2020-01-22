using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7};

            //length
            Console.WriteLine(numbers.Length);

            //indexOf
          var index =  Array.IndexOf(numbers,7);
            Console.WriteLine("index of 7 is"+index);

            //clear method
            Array.Clear(numbers,0,3);

            Console.WriteLine("check the cleared elements");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            //copy array
            var copy = new[] {1, 2, 3, 4};
            Array.Copy(numbers,copy,3);
            Console.WriteLine("copy array function");
            foreach (var n in copy)
            {
                Console.WriteLine(n);
            }
            //sort()
            Array.Sort(numbers);
            Console.WriteLine("sort() array function");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            //REVERSE()
            Array.Reverse(numbers);
            Console.WriteLine("reverse() array function");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}

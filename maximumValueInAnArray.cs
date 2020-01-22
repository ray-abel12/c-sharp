using System;

namespace series_of_numbers
{
    class Program
    {
       
    
        static void Main(string[] args)
        {
            Console.WriteLine("enter length of value");
            var arrayLengthInput = Console.ReadLine();
            var arrayLength = Convert.ToInt32(arrayLengthInput);

            var numbers = new int[3];
         

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("enter values and press ok");
                var arrayInput = Console.ReadLine();
                var ConvertedArrayInput = Convert.ToInt32(arrayInput);
               
                numbers[i] = ConvertedArrayInput;
               
                Console.WriteLine("");
            }
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine("the maximum value is " + numbers[0]);
            
            
            {
                
            }
        }
    }
}

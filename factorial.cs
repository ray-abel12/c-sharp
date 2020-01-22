using System;

namespace factorial
{
    class factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value to get factorial value");
            var userInput = Console.ReadLine();
            var convertedInput = Convert.ToInt32(userInput);
            var total = 1;

            for (int i = 1; i <= convertedInput; i++)
            {
              
                  total*= i;
                
            }
            Console.WriteLine($"the factorial of {convertedInput}! = {total}");
        }
    }
}

using System;
using System.Linq;

namespace StringDublicate
{
    class StringDublicate
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter numbers seperated by -");
                var userInput = Console.ReadLine();
                var numbers = userInput.Split('-').Select(text => Convert.ToInt32(text));
                if (string.IsNullOrWhiteSpace(userInput)) break;
            }
        }
    }
}
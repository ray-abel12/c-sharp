using System;

namespace doWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter name");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                Console.WriteLine("@echo "+input);
            }
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
           var random =new Random();
           var generatedRandomValue = random.Next(1, 10);

           int i = 0;
           while (i < 4)
           {
               Console.WriteLine(generatedRandomValue);
               Console.WriteLine("quest the number ");
               var userInput = Console.ReadLine();
               var intUserInput = Convert.ToInt16(userInput);

               

                if (generatedRandomValue == intUserInput)
               {
                   Console.WriteLine("you won");
                   break;
                }
                else
                {
                    Console.WriteLine($"wrong try again");
                }

                i++;
           }
           
        }
    }
}

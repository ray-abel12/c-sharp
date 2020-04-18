using System;
using System.Collections.Generic;

namespace Vowels
{
    class Vowels
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a english word");
            var input = Console.ReadLine().ToLower();
            
            if(string.IsNullOrWhiteSpace(input))
                return;

            var words = new List<char>();
            var value = 0;

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == 'a')
                {
                    value++;
                }else if (words[i] == 'e')
                {
                    value++;
                }
            }
        }
    }
}
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
            foreach (var index in input)
            {
                words.Add(index);
            }

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == 'a')
                {
                    value++;
                    
                }else if (words[i] == 'e')
                {
                    value++;
                } else if (words[i] == 'i')
                {
                 value++;
                 }else if (words[i] == 'o')
            {
                value++;
            }else if (words[i] == 'u')
            {
                value++;
                
            }

                
            }
            Console.WriteLine(value);
        }
    }
}
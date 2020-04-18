using System;
using System.Collections.Generic;

namespace PascalCase
{
    class PascalCase
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                Console.WriteLine(word[0]);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }

        }
    }

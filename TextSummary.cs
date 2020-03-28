using System;
using System.Collections.Generic;

namespace TextSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxLength = 20;
            var sentence = "i just wanna type a very long text here";
            
            if(sentence.Length < 20 )
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                   summaryWords.Add(word); 
                   totalCharacters += words.Length + 1;

                   //   if (totalCharacters > maxLength)
                   //    break;
                }

                var summary = string.Join("  ", summaryWords) + "...";
                Console.WriteLine(summary);

            }
            
        }
    }
}
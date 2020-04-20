using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadTextFileAndNumberOfWords
{
    class ReadTextFileAndCount
    {
        public static string content = " ";
        static void Main(string[] args)
        {
            ReadTextFile();
            var result = GetNoOfWords(); 
            Console.WriteLine(result);
        }

        public static string ReadTextFile()
        {
            var path = @"C:\Users\RAY-ABEL\folder\read.txt";
             content = File.ReadAllText(path);
            Console.WriteLine(content);
            return content;
        }

        public static int GetNoOfWords()
        {

            var texts = content.Split('');
           
            var characters = new List<int>();
            foreach (var text in texts)
            {
                characters.Add(Convert.ToInt32(text));
            }

            var wordCount = characters.Count;
            return wordCount;

        }
    }
}
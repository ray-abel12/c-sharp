using System;
using System.Collections.Generic;

namespace reverseName
{
    class Program
    {
        static void Main(string[] args)

        {

            
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("reverse name is " + reversed);
            
        }

        public static string ReverseName(string nameInput)
            {

                var names = new char[nameInput.Length];

                for (int i = names.Length; i > 0; i--)
                {

                    names[names.Length - i] = nameInput[i - 1];
                }
                
                return new string(names);
            }
        }
}
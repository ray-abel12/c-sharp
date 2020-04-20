using System;
using System.Collections.Generic;

namespace reverseName
{
    class Reverse
    {
        static void Main(string[] args)

        {

            
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("reverse name is " + reversed);
            
        }

        public static string ReverseName(string name)
            {

                var names = new char[name.Length];

                for (int i = names.Length; i > 0; i--)
                {

                    names[names.Length - i] = name[i - 1];
                }
                
                return new string(names);
            }
        }
}
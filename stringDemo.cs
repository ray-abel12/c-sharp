using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            var name = new string("abel");
            var num = "12345";
            
            var result = int.Parse(num);
            var result2 = Convert.ToInt32(result);
            
            Console.WriteLine(result2);
            Console.WriteLine(result);
           var newName = name.Replace('a', 'z');
            Console.WriteLine(newName);
            

        }
    }
}
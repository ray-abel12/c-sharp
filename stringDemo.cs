using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*var name = new string("abel");
            var name2 = new string("abel");
            var num = "12345";
            
            var result = int.Parse(num);
            var result2 = Convert.ToInt32(result);
            
            Console.WriteLine(result2);
            Console.WriteLine(result);
           var newName = name.Replace('a', 'z');
         var result3 =  string.Compare(name, name2);
         Console.WriteLine(result3);
            Console.WriteLine(newName);
            */
            var fullName = "abel ray";
            var index = fullName.IndexOf(' ');
            var name = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine(name);
            Console.WriteLine(lastName);
        }
    }
}
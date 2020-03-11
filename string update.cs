using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var name = "ABEL".ToLower().Trim();
            var name2 = "ABEL".ToUpper();

            name.Split(',');
            
            Console.WriteLine(name);
            Console.WriteLine(name2);*/

            var fullName ="abel ray";
            Console.WriteLine("trim:'{0}'",fullName.Trim());
            Console.WriteLine("To upper:'{0}'",fullName.ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("firstName:"+ firstName);
            Console.WriteLine("lastname:"+ lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("first Name:"+names[0]);
            Console.WriteLine("last Name:"+names[1]);

            
            Console.WriteLine(fullName.Replace("ray", "obeya"));
            
            //verification for input from user 
            if(string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("invalid");

        }
    }
}
using System;

namespace NameReverse
{
    public class NameReverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            var name = Console.ReadLine();
            
           var array = new char[name.Length -1];
           

           for(var i =array.Length; i>=0; i--)
            {
                
                var nameLength =Convert.ToString(name[i]) ;

                var reverse =new string(nameLength);
                Console.Write(nameLength);
            }
        }
    }
}

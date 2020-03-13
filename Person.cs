using System;

namespace FirstMethod
{
   public class Person
   {
       public String Name ;

       public  void Introduce()
       {
           Console.WriteLine("Hello my name is "+ Name);
       }

       public static Person Parse(String str)
       {
          var program = new Person();
          program.Name = str;
          return program;
       }
       static void Main(string[] args)
       {
           var program = new Person();
           var p = Person.Parse("john");
           Console.WriteLine(p);
           
       }
    }
}
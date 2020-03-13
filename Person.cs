using System;

namespace FirstMethod
{
   public class Person
   {
       public String Name ;

       public  void Introduce(string to)
       {
           Console.WriteLine("Hi {0} i am {1}",to,Name);
       }

       public static Person Parse(String str)
       {
          var program = new Person();
          program.Name = str;
          return program;
       }
       static void Main(string[] args)
      {
//           var person = new Person();
//           person.Name = "abel";
           // person.Introduce("mosh");
          //using the static method
          var person = Person.Parse("john");
          person.Introduce("morsh");

      }
    }
}
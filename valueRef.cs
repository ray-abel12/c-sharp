using System;
using System.Security.Cryptography.X509Certificates;

namespace valueOrReference
{
   public class Person
   {
       public int Age;
        static void Main(string[] args)
        {
            var number = 1;
            Value(number);
            Console.WriteLine(number);
            var person = new Person();
            var age = person.Age = 46;
            Console.WriteLine(age);

        }
        public static void Value(int number)
        {
            number += 10;
            
        }

        public static void MakeOld(Person person)
       {
         person.Age += 10;
        }
    }
}

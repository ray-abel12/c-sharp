using System;

namespace RandomNumber
{
    public class PasswordGeneratorProgram
    {
        static void Main(string[] args)
        {
            
            var random =new Random();
            var buffer = new char[10];
            for (int i = 0; i < 10; i++)
                buffer[i] = ((char) ('a' + random.Next(0, 26)));
            string password;
            password = new string(buffer);
            Console.Write("generated password is ");
            Console.Write(buffer);
            
        }
    }
}

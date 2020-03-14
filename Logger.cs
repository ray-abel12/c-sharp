using System;

namespace Composition
{
    public class Logger
    {
        public void log(string message)
        {
            Console.WriteLine("the message is "+ message);
        }
    }
}
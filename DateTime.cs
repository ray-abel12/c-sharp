using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace play7
{
    class Program
    {
        static void Main(string[] args)
        {
             var dateTime = new DateTime(2015,1,1);
             var now = DateTime.Now;
             var today = DateTime.Today;
             var tomorrow = dateTime.AddDays(1);
             
          //   Console.WriteLine(dateTime);
             /*Console.WriteLine("hour "+now.Hour);
             Console.WriteLine("minute "+now.Minute);
             Console.WriteLine("seconds "+now.Second);
             Console.WriteLine("miliseconds "+now.Millisecond);*/

             Console.WriteLine(now.ToLongDateString());
             Console.WriteLine(now.ToLongTimeString());
             Console.WriteLine(now.ToShortDateString());
             Console.WriteLine(now.ToShortTimeString());
             Console.WriteLine(now.ToString("U"));

        }
    }
}
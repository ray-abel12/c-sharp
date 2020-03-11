using System;
using System.Net.Sockets;

namespace TimeShift
{
    class Program
    {
        static void Main(string[] args)
        {
           var timeSpan = new TimeSpan(2,2,3);
          //  Console.WriteLine(timeSpan);

         // var timeSpan = TimeSpan.FromHours(1);
           //timespan objects being created 
           
          var start = DateTime.Now;
          var end = DateTime.Now.AddMinutes(1);

          var duration = end.Subtract(start);
          Console.WriteLine("duration "+ duration);

          //Console.WriteLine(timeSpan);
          //properties
          Console.WriteLine("min "+ timeSpan.Minutes);
          //timespan is inclusive of all the hours,min and seconds calculated together  
          Console.WriteLine("totalmin "+timeSpan.TotalMinutes);
          //add to the timespan because dateTime are immuntable
          Console.WriteLine("add to the timespan "+ timeSpan.Add(TimeSpan.FromMinutes(12)));
          Console.WriteLine("subtract from timespan "+ timeSpan.Subtract(TimeSpan.FromMinutes(12)));
          
          //tostring 
          Console.WriteLine("tostring " +timeSpan.ToString());
          //parse
          Console.WriteLine("parse "+ TimeSpan.Parse("01:01:01"));
        }
    }
}
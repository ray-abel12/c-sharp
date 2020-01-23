using System;

namespace dateTime
{
    public class DateTime
    {
        static void Main(string[] args)
        {
       var dateTime =new DateTime();
       var now = System.DateTime.Now;
       var today = System.DateTime.Today;

     //  Console.WriteLine($"{now.Hour}:{now.Minute}:{now.Second}");
     var tomorrow = now.AddDays(1);
     var yerstaday = now.AddDays(-1);

     Console.WriteLine(now.ToLongDateString());
     Console.WriteLine(now.ToShortDateString());
     Console.WriteLine(now.ToString("F"));

        }
    }
}

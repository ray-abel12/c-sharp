using System;
using System.ComponentModel.DataAnnotations;

namespace cFundamentals2
{
    public enum shippingMethods
    {
        RegularAirMail = 10,
        RegisteredAirMail = 12,
        Express = 15

    }
    class Program
    {
        static void Main(string[] args)
        {
            var methods = shippingMethods.Express;
            Console.WriteLine((int)methods);
            var methodId = 15;
            Console.WriteLine((shippingMethods)methodId);
        }
        //parse a sting to an enum
     //   string method1 = "express";
     //   private var shippingMethods = Enum.Parse(typeof(shippingMethods), method1);
    }
}

using System;
using System.IO;

namespace Path
{
    class Path
    {
        static void Main(string[] args)
        {
            var path = @"C:\code\c\ReverseName.txt";
            Console.WriteLine(System.IO.Path.GetExtension(path));
            
        }
    }
}
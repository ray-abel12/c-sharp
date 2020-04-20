using System;
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\RAY-ABEL\folder\read.txt";
          //  File.Copy(@"C:\Users\RAY-ABEL\folder\The_Hustle.mp4",@"C:\Users\RAY-ABEL\destination\test.txt,true");
      // var text = File.ReadAllText(path);
       //Console.WriteLine(text);
       
       var fileInfo = new FileInfo(path);
       //fileInfo.CopyTo(..)
       var check = fileInfo.Exists;
       Console.WriteLine(check);
        }
    }
}
using System;
using System.IO;

namespace DirectoryAndDirectoryinfo
{
    class DirectoryAndDirectoryInfo
    {
        static void Main(string[] args)
        {
            var path = @"C:\code\c";
          var files = Directory.GetFiles(@"C:\code\c", "*.*");
          foreach (var file in files)
          {
              Console.WriteLine(file);
          }
          var directoryInfo = new DirectoryInfo(path);
          var exits = directoryInfo.Exists;
          Console.WriteLine(exits);
        }
    }
}
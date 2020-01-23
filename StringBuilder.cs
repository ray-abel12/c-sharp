using System;
using System.Text;
namespace StringBuilder
{
    class StringBuilder
    {
        static void Main(string[] args)
        {
            var stringBuilder = new System.Text.StringBuilder();
          stringBuilder.Append('-', 10);
          stringBuilder.AppendLine();
          stringBuilder.Append("Header");
          stringBuilder.AppendLine();
            stringBuilder.Append('-', 10);
            stringBuilder.Remove(0, 10);
            Console.WriteLine(stringBuilder);
        }
    }
}

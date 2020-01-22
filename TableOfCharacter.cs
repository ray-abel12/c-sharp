using System;

namespace table_of_characters
{
    class TableOfCharacter
    {
        static void Main(string[] args)
        {
            char read;
            for (int i = 1; i <= 122; i++)
            {
                read = Convert.ToChar(i);
                Console.WriteLine($"the ascii value of {i} is {read}");
            }
        }
    }
}

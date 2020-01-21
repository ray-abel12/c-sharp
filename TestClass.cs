using System;
using cSharpFundamentals.maths;
using cSharpFundamentals.structure;
using cSharpFundamentals.structure.arrays;

namespace cSharpFundamentals
{
    class TestClass
    {
        static void Main(string[] args)
        {
            var abel =new Person();
            abel.fName = "abel";
            abel.lName = "ray1";
            abel.introduce();
            Console.WriteLine($"my name is {abel.fName} {abel.lName}");
            Console.WriteLine($"{Calculator.add(12,16)}");
            //instance of rgb
            var rgb = new Rgb();
            Console.WriteLine($" color is {rgb.blue = "blue"} {rgb.pink = "pink"} {rgb.red="red"}");
            

            
                Arrays array = new Arrays();
                array.arrays();
                Console.WriteLine(" ");
            //arrays
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            Console.WriteLine(flags[0] = true);
            Console.WriteLine(flags[1] );
            Console.WriteLine(flags[2] );
            var names = new string[3]{"abel","john","mummy"};
            string list = string.Join(",", names);
            Console.WriteLine(list);

            //string
            string name = "abel";
            char fistName = name[0];
            Console.WriteLine(name[0]);
            //more stings
            var firstName = "sam";
            var lastName = "immanuel";
            var fullName = string.Format("{0} {1}",firstName,lastName);
            Console.WriteLine(fullName);
            var text = @"hello look into this  c:/folder/here ";
            Console.WriteLine(text);
            //enum

        }
        }
}

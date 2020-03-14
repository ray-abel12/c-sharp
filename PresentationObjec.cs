using System;

namespace Inheritance
{
    public class PresentationObjec
    {
        public int Height { get; set; }
        public int Weidth { get; set; }

        public void copy()
        {
            Console.WriteLine("object was copy to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("object  duplicate");
        }
    }
}
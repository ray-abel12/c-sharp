using System;

namespace Inheritance
{
    public class Text : PresentationObjec
    {
        public int FrontSize { get; set; }
        public string FrontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("we added a link you ur url "+url);
        }
    }
}
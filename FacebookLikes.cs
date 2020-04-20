using System;
using System.Collections.Generic;

namespace Facebook
{
    class FacebookLikes
    {
        static void Main(string[] args)
        {
            var userNames = new List<string>();
            while (true)
            {
                Console.WriteLine("enter name");
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    break;
                

                userNames.Add(name);
                
            }
            GetNumberOfUser(userNames);
        }
        public static void GetNumberOfUser(List<string> userNames)
        {
            var numberOfUsers = userNames.Count - 2;
            if (userNames.Count == 0)
                Console.WriteLine("");
            else if(userNames.Count ==1)
                Console.WriteLine(userNames[0] + "likes your post");
            else if(userNames.Count ==2)
                Console.WriteLine("{0} and {1} like your post",userNames[0],userNames[1]);
            else if (userNames.Count > 2)
                Console.WriteLine("{0},{1} and {2} other liked your post",userNames[0],userNames[1],numberOfUsers);
            else
            {
                Console.WriteLine("error");
            }

            
        }
    }
}
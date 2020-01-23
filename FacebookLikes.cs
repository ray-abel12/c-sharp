using System;
using System.Collections.Generic;

namespace FacebookLikes
{
    public class FacebookLikes

    {
        static void Main(string[] args)
        {
            
            var listName = new List<string>();
          //  var userName = Console.ReadLine();
          var convertedUserName = "hello";
            while (convertedUserName != string.Empty)
            {
                Console.WriteLine("enter facebook names or enter to end");
                var userName = Console.ReadLine();
                convertedUserName = Convert.ToString(userName);
                listName.Add(convertedUserName);

                
            }

            if (listName.Count == 0)
            {
                Console.WriteLine("no likes");
            }

            if (listName.Count == 1)
            {
                Console.WriteLine($"{listName[0]}  like your post");
            }
            if (listName.Count == 2)
            {
                Console.WriteLine($"{listName[0]} and {listName[1]}  like your post");
            }
            if (listName.Count > 2)
            {
                var otherUsers = listName.Count - 2;
                Console.WriteLine($"{listName[0]} {listName[1]} and {otherUsers} other person likes your post");
            }

        }
    }
}

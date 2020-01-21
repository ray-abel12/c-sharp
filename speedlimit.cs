using System;

namespace speedlimit
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("enter speed limit");
           var speedLimit = Console.ReadLine();
           var speedlimit = Convert.ToInt32(speedLimit);

           Console.WriteLine("enter car speed");
           var carSpeed = Console.ReadLine();
           var carspeed = Convert.ToInt32(carSpeed);

           if (speedlimit >= carspeed)
           {
               Console.WriteLine("ok");
            }
           else
           {
               var result = carspeed - 20;
               var Limit = result;
              
               switch (Limit)
               {
                    case 5:
                        Console.WriteLine("you have 1 demerit point");
                        break;

                    case 10:
                        Console.WriteLine("you have 2 demerit point");
                        break;

                    case 15:
                        Console.WriteLine("you have 3 demerit point");
                        break;

                    case 20:
                        Console.WriteLine("you have 4 demerit point");
                        break;

                    case 25:
                        Console.WriteLine("you have 5 demerit point");
                        break;

                    case 30:
                        Console.WriteLine("you have 6 demerit point");
                        break;

                    case 35:
                        Console.WriteLine("you have 7 demerit point");
                        break;

                    case 40:
                        Console.WriteLine("you have 8 demerit point");
                        break;

                    case 45:
                        Console.WriteLine("you have 9 demerit point");
                        break;

                    case 50:
                        Console.WriteLine("you have 10 demerit point");
                        break;

                    case 55:
                        Console.WriteLine("you have 11 demerit point");
                        break;

                    case 60:
                        Console.WriteLine("you have 12 demerit point");
                        break;

                    default:
                        Console.WriteLine("your licence has been supended for overspeeding");
                        break;
                }

           }
           
        }
    }
}

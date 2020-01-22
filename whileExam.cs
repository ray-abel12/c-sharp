using System;

namespace exams
{
    class WhileCaseExams
    {
        static void Main(string[] args)
        {
            var conditionInput = string.Empty ;
            var stringInput = string.Empty;
            int pass = 0;
            int fail = 0;
            while (conditionInput !="ok")
                
            {
                Console.WriteLine("welcome to your it exams");
                Console.WriteLine(@"1. What is the meaning of the acronym CPU ?

                1.Centrally Provided Users
                2.Centric Processing Unit
                3.Central Processing Unit
                4.Creepy Pointed Unit");

                var input = Console.ReadLine();
                int answerInput = Convert.ToInt32(input);
                if (answerInput == 3)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }

                Console.WriteLine(@"2. What is recognized as the main circuit board in a computer ?

                    1.The graphics card
                    2.The sound card
                    3.The CPU
                    4.The motherboard");

                input = Console.ReadLine();
                answerInput = Convert.ToInt32(input);
                if (answerInput == 4)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
                Console.WriteLine(@"3.Where would you most likely find a CPU ?

                1.On a mailbox
                2.On top of a computer
                3.In Drama class
                4.On a motherboard");

                input = Console.ReadLine();
                answerInput = Convert.ToInt32(input);
                if (answerInput == 4)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
                Console.WriteLine(@"4.What does the acronym RAM stand for ?

                    1.Random Access Memory
                    2.Random Archival Method
                    3.Really Awful Methods
                    4.Rotating Arm Memory");

                input = Console.ReadLine();
                answerInput = Convert.ToInt32(input);
                if (answerInput == 1)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
                Console.WriteLine(@"5.What describes a Network in computer terms ?

                    1.group of friends talking the phone 
                    2. group of computers working together
                    3.All the people who support phone calls on cellular phones
                    4.Anyone doing work");

                input = Console.ReadLine();
                answerInput = Convert.ToInt32(input);
                if (answerInput == 2)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
                Console.WriteLine("type ok to end");
                stringInput = Console.ReadLine();
                conditionInput = Convert.ToString(stringInput);

            }
            Console.WriteLine($"you got {pass} correctly and failed {fail}");
            if (pass == 5)
            {
                Console.WriteLine("excellent");
            }
            else
            {
                Console.WriteLine("try harder");
            }
        }
    }
}

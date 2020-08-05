using System;

namespace _02.SystemTest
{
    class SystemTest
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int startTime = Environment.TickCount;

            //the code fragment to be tested
            for (int i = 0; i < 10000000; i++)
            {
                sum++;
            }

            int endTime = Environment.TickCount;
            Console.WriteLine("The time elapsed is {0} sec.", (endTime - startTime) / 1000.0);
        }
    }
}

using System;

namespace _01
{
    class Demo
    {

        static void Recursion(int steps)
        {
            Console.WriteLine($"called at {steps}");

            if (steps <= 0)
            {
                Console.WriteLine($"returns at {steps}");
                return;
            }
            Recursion(steps - 1);
            Console.WriteLine($" 26 returns at {steps}");
        }
        static void Main(string[] args)
        {
            Recursion(5);
            Console.WriteLine("Back in main");
        }
    }
}

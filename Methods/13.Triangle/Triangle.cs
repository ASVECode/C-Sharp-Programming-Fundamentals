using System;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            //Entering the value of the variables n
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            // Console.WriteLine();

            //printing the upper part of the triangle
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            //  printing the bottom part of the triangle
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
    }
}

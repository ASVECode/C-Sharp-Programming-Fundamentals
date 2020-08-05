using System;

namespace _02.CalculateSum
{
    class CalculateSum
    {
        static long CalcSum(params int[] elements)
        {
            long sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            long sum = CalcSum(2, 5);
            Console.WriteLine(sum);

            long sum1 = CalcSum(-2, 5, 12, 18);
            Console.WriteLine(sum1);

            long sum2 = CalcSum(2, 5, 85);
            Console.WriteLine(sum2);

            long sum3 = CalcSum();
            Console.WriteLine(sum3);
        }
    }
}

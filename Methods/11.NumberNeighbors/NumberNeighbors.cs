using System;

namespace NumberNeighbors
{
    class NumberNeighbors

    {

        static void CheckBiggerOrSmaller(int position, params int[] numbers)
        {
            if (position == 0)
            {
                if (numbers[1] > numbers[0])
                {
                    Console.WriteLine("Bigger");
                }
                else
                {
                    Console.WriteLine("smaller");
                }
            }
            else if (position == numbers.Length - 1)
            {
                if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
                {
                    Console.WriteLine("Bigger");
                }
                else
                {
                    Console.WriteLine("smaller");
                }
            }
            else
            {
                if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
                {
                    Console.WriteLine("Bigger");
                }
                if (numbers[position] < numbers[position - 1] && numbers[position] < numbers[position + 1])
                {
                    Console.WriteLine("Smaller");
                }
            }

        }
        static void Main(string[] args)
        {
            CheckBiggerOrSmaller(4, new int[] { 1, 2, 3, 4, 5, 4, 6 });
        }
    }
}

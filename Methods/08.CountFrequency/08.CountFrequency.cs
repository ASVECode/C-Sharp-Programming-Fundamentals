using System;

namespace _08.CountFrequency
{
    class Program
    {
        static void CountFrequency(int number, params int[] numbers)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (number == numbers[i])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            CountFrequency(5, new int [] { 4, 3, 5, 9, 12, 5, 8, 6, 8, 4});
        }
    }
}


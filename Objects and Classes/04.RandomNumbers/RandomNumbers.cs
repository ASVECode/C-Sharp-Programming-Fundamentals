using System;

namespace _04.RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 1; i <= 6; i++)
            {
                int randomNumber = rand.Next(49) + 1;
                Console.WriteLine("{0}", randomNumber);

            }
        }
    }
}

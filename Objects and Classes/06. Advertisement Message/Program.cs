using System;

namespace _06._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int randomNumber = rand.Next(100) + 100;
                Console.WriteLine("{0}", randomNumber);

            }
        }
    }
}

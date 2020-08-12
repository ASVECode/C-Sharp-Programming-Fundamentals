using System;
using System.Collections.Generic;

namespace _04.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                Random rdn = new Random();
                string message = phrases[rdn.Next(0, phrases.Length)] + " ";
                message += events[rdn.Next(0, events.Length)] + " ";
                message += authors[rdn.Next(0, authors.Length)] + "-";
                message += cities[rdn.Next(0, cities.Length)];

                Console.WriteLine(message);

            }

        }
    }
}


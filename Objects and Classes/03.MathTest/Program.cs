using System;

namespace _03.MathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length of the first side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Length of the second side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Size of the angle in degrees:");
            int angle = int.Parse(Console.ReadLine());

            double angleInRadians = Math.PI * angle / 180.0;
            Console.WriteLine("Face of the triangle: {0}", 0.5 * a * b * Math.Sin(angleInRadians));
        }
    }
}

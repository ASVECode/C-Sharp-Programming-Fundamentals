using System;
using System.Numerics;

namespace _08.FastPower
{
    class Program
    {

        static BigInteger FastPower(int n, int p)
        {
            if (p == 0)
            {
                return 1;
            }

            if (p % 2 == 1)
            {
                return n * FastPower(n, p - 1);
            }

            BigInteger half = FastPower(n, p / 2);
            return half * half;
        }
        static void Main()
        {
            Console.WriteLine(FastPower(42, 30));
        }
    }
}

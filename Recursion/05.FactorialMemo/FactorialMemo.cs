using System;
using System.Numerics;

namespace _05.FactorialMemo
{
    class Program
    {
        static BigInteger[] FactorialMemo = new BigInteger[1000000];
        static BigInteger Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (FactorialMemo[n] == 0)
            {
                FactorialMemo[n] = n * Factorial(n - 1);
            }
            return FactorialMemo[n];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(80));
            Console.WriteLine(Factorial(80));
            Console.WriteLine(Factorial(80));
        }
    }
}

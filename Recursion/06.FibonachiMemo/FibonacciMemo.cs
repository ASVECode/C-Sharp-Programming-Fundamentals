using System;
using System.Numerics;

namespace _06.FibonachiMemo
{
    class FibonachiMemo
    {
        static BigInteger Fibonacci(int n, BigInteger[] memo)
        {
            if ((n == 1) || (n == 2))
            {
                return 1;
            }
            else
            {
                if (memo[n] == 0)
                {
                    memo[n] = Fibonacci(n - 1, memo) + Fibonacci(n - 2, memo);
                }
                return memo[n];
            }


        }
        static void Main(string[] args)
        {
            var memo = new BigInteger[1000];
            Console.WriteLine(Fibonacci(9, memo));
        }
    }
}

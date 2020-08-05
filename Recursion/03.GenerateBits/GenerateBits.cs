using System;

namespace _03.GenerateBits
{
    class GenerateBits
    {
        static void Bits(int n, string bits)
        {
            if (n == 0)
            {
                Console.WriteLine(bits);
                return;
            }
            Bits(n - 1, bits + "0");
            Bits(n - 1, bits + "1");

        }
        static void Main(string[] args)
        {
            Bits(8, "");
        }
    }
}

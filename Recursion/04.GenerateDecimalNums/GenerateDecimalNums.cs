using System;

namespace _04.GenerateDecimalNums
{
    class GenerateDecimalNums
    {
        static void GenerateDecimal(int n, string nums)
        {
            if (n == 0)
            {
                Console.WriteLine(nums);
                return;
            }
            GenerateDecimal(n - 1, nums + "0");
            for (int d = 1; d <= 9; ++d)
            {
                GenerateDecimal(n - 1, nums + d);
            }
        }

        static void Main()
        {
            GenerateDecimal(3, "");
        }
    }
}

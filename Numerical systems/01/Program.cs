using System;
using System.Collections.Immutable;
using System.Runtime.InteropServices.ComTypes;
// Decimal to Binary (148, 35, 43, 251, 0.41)
namespace _01
{
	class Program
	{
		public static string ReverseString(string str)
		{
			char[] chars = str.ToCharArray();
			for (int i = 0, j = str.Length - 1; i < j; i++, j--)
			{
				char c = chars[i];
				chars[i] = chars[j];
				chars[j] = c;
			}
			return new string(chars);
		}
		static void DecimalToBinary(params double[] numbers)
		{
			for (int i = 0; i < numbers.Length; i++) 
			{
				string result = "";
				int decimalNum = (int)numbers[i];
                while (decimalNum > 0)
                {
					if (decimalNum < 1)
                    {
						while(result.Length <= 8)
                        {
							decimalNum *= 2;
                            if (decimalNum < 1)
                            {
								result += 0;
								decimalNum *= 2;
                            }
                            else
                            {
								decimalNum -= 1;
								result += 1;
                            }

						}
                        Console.WriteLine(result);
                    }
                    else
                    {
						if (decimalNum % 2 == 0)
						{
							result += 0;
							decimalNum /= 2;
						}
						else
						{
							result += 1;
							decimalNum--;
							decimalNum /= 2;
						}
					}
					
				}
                Console.WriteLine(ReverseString(result));
			}
		}
		static void Main(string[] args)
		{
			double[] numbers = { 148, 35, 43, 251, 0.41 };
			DecimalToBinary(numbers);
		}

	}
}

using System;

namespace _03.SquareRoot
{
    public class SquareRoot
    {
        public static void Main(string[] args)
        {
            try
            {
                long num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException("Number should be positive or 0.");
                }

                Console.WriteLine($"Square root of {num} is {Math.Sqrt(num)}");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}


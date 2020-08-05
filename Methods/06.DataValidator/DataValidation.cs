using System;

namespace _06.DataValidator
{
    class DataValidator
    {
        static bool DataValidation(int hours, int minutes)
        {
            bool result = ((hours >= 0 && hours < 24) && (minutes <= 59 && minutes >= 0));
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("What time is it?");
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            bool isValidTime = DataValidation(hours, minutes);

            if (isValidTime)
            {
                Console.WriteLine("The time is {0}:{1} now.", hours, minutes);
            }
            else
            {
                Console.WriteLine("Invalid time!");
            }
        }
    }
}

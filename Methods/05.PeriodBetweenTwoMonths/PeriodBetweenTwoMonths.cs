using System;

namespace _05.PeriodBetweenTwoMonths
{
    class PeriodBetweenTwoMonths
    {
        static string GetMonth(int month)
        {
            string monthName = "";
            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    Console.WriteLine("Invalid month!");
                    return null;
            }
            return monthName;
        }
        static void PeriodBetweenMonths(int startMonth, int endMonth)
        {
            int period = endMonth - startMonth;
            if (period < 0)
            {
                period += 12;
            }
            Console.WriteLine("There is {0} months period from {1} to {2}.", period, GetMonth(startMonth), GetMonth(endMonth));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First month (1-12) : ");
            int firstMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Second month (1-12) : ");
            int secondMonth = int.Parse(Console.ReadLine());

            PeriodBetweenMonths(firstMonth, secondMonth);
        }
    }
}

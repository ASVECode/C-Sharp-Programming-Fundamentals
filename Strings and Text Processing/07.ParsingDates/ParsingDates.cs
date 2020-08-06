using System;

namespace _08.ParsingDates
{
    class ParsingDates
    {
        static void Main(string[] args)
        {
            string text = "11/11/2001";
            DateTime parsedDate = DateTime.Parse(text);
            Console.WriteLine(parsedDate);
        }
    }
}

using System;

namespace _03.MultipleSeparators
{
    class MultipleSeparators
    {
        static void Main()
        {
            string listOfBeers = "Amstel, Zagorka. Tuborg, Becks";
            char[] separators = new char[] { ' ', ',', '.' };
            string[] beersArr = listOfBeers.Split(separators);
            foreach (string beer in beersArr)
            {
                if (beer != "")
                {
                    Console.WriteLine(beer);
                }
            }
        }
    }
}

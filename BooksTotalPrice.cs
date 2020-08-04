using System;

namespace _01.BooksTotalPrice
{
    class BooksTotalPrice
    {
        static void PrintTotalAmountForBooks(decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in prices)
            {
                totalAmount += singleBookPrice;
            }
            Console.WriteLine("The total amount of all books is: " + totalAmount);
        }
        static void Main(string[] args)
        {
            decimal[] booksPrice = { 10.50m, 15.70m, 7, 49 };
            PrintTotalAmountForBooks(booksPrice);
        }
    }
}

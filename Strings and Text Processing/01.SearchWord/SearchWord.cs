using System;
namespace _01.SearchWord
{
    class SearchWord
    {
        static void Main()
        {
            string quote = "the main intent of the \"Intro C#\"" + "book is to introduce the C# programming to the newbies.";
            string keyword = "C#";
            int index = quote.IndexOf(keyword);

            while (index != -1)
            {
                Console.WriteLine("{0} found at index: {1}", keyword, index);
                index = quote.IndexOf(keyword, index + 1);
            }
        }
    }
}

using System;
using System.Globalization;

namespace _02.ExtractingFileName
{
    class ExtractingFileName
    {
        static void Main(string[] args)
        {
            string path = "C:\\Pics\\Rila2010.jpg";
            int index = path.LastIndexOf("\\");
            string fullName = path.Substring(index + 1);
            Console.WriteLine(fullName);
        }

    }
}

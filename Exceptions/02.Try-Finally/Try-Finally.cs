using System;
using System.IO;

namespace _02.Try_Finally
{
    class Program
    {
        static void Main()

        {
            string filename = "WrongTextFile.txt";
            ReadFile(filename);
        }
        static void ReadFile(string fileName)
        {
            TextReader reader = null;

            try
            {
                reader = new StreamReader(fileName);
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            finally
            {
                // Always close "reader" (first check if properly opened)

                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}

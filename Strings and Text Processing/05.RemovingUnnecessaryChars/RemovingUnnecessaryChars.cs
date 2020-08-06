using System;

namespace _05.RemovingUnnecessaryChars
{
    class RemovingUnnecessaryChars
    {
        static void Main(string[] args)
        {
            string fileData = "   \n\n     David Allen    ";
            string reduced = fileData.Trim();
            Console.WriteLine(reduced);

           // Removing Unnecessary Characters by a Given List
            string fileData1 = "   111 $  %    David Allen  ### s   ";
            char[] trimChars = new char[] { ' ', '1', '$', '%', '#', 's' };
            string reduced1 = fileData1.Trim(trimChars);
            Console.WriteLine(reduced1);

        }
    }
}

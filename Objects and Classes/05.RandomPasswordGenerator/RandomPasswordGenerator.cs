using System;
using System.Globalization;
using System.Text;

namespace _05.RandomPasswordGenerator
{
    class RandomPasswordGenerator
    {
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars = "!@#$%^&*()_+-=[]{}\\|':;./?<>";
        private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;

        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder();
            //generate 2 random capital letters
            for (int i = 1; i < 2; i++)
            {
                char capitalLetter = GenerateChar(CapitalLetters);
                InsertAtRandomPosition(password, capitalLetter);
            }

            //generate 2 random small letters
            for (int i = 1; i < 2; i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                InsertAtRandomPosition(password, smallLetter);
            }
            //generate one random digit
            char digit = GenerateChar(Digits);
            InsertAtRandomPosition(password, digit);

            //generate 3 special characters
            for (int i = 1; i < 3; i++)
            {
                char specialChar = GenerateChar(SpecialChars);
                InsertAtRandomPosition(password, specialChar);
            }

            //generate few random characters 
            int count = rnd.Next(8);
            for (int i = 1; i < count; i++)
            {
                char specialChar = GenerateChar(AllChars);
                InsertAtRandomPosition(password, specialChar);
            }
            Console.WriteLine(password);
        }

        private static void InsertAtRandomPosition(StringBuilder password, char character)
        {
            int randomPosition = rnd.Next(password.Length + 1);
            password.Insert(randomPosition, character);
        }

        private static char GenerateChar(string availableChars)
        {
            int randomIndex = rnd.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }
    }
}

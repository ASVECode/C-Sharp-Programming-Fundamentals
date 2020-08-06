using System;
using System.Text.RegularExpressions;

namespace _04.CensorMobileNumbers
{
    class CensorMobileNumbers
    {
        static void Main()
        {
            string doc = "Smith's number: 0895648922\nFranky can be " + "found at 0895462778.\nSteven' mobile number: 0884956236";
            string replacedDoc = Regex.Replace(doc, "(08)[0-9]{8}", "$1********");
            Console.WriteLine(replacedDoc);


        }
    }
}

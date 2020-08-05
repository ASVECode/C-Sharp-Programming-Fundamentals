using System;

namespace TemperatureConverter
{
    class TemperatureConverter
    {

        static double ConvertFahrenheitToCelsius(double temperatureF)
        {
            double temperatureC = (temperatureF - 32) * 5 / 9;
            return temperatureC;
        }
        static void Main()
        {
            Console.WriteLine("Enter your body temperature in Fahrenheit degrees: ");
            double temperature = double.Parse(Console.ReadLine());
            temperature = ConvertFahrenheitToCelsius(temperature);

            Console.WriteLine("Your body temperature in Celsius degrees is {0}.", temperature);

            if (temperature >= 37)
            {
                Console.WriteLine("You are ill");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            double carHoursePower = 0;
            int countCar = 0;
            int countTruks = 0;
            double truckHoursePower = 0;
            List<Vehicle> vehicles = new List<Vehicle>();
            string[] tokens = Console.ReadLine().Split(separator: " ");
            while (tokens[0] != "End")
            {
                Vehicle vehicle = new Vehicle(tokens[0], tokens[1], tokens[2], int.Parse(tokens[3]));
                if (vehicle.Type == "car")
                {
                    countCar++;
                    carHoursePower += vehicle.HoursePower;
                }
                else
                {
                    countTruks++;
                    truckHoursePower += vehicle.HoursePower;
                }
                vehicles.Add(vehicle);
                tokens = Console.ReadLine().Split(separator: " ");
            }

            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    Console.WriteLine($"Cars have average horsepower of: {(carHoursePower / countCar):F2}.\nTrucks have average horsepower of: {(truckHoursePower / countTruks):F2}.");
                    break;
                }

                foreach (var veh in vehicles)
                {
                    if (model == veh.Model)
                    {
                        Console.WriteLine(veh.ToString());
                        break;
                    }

                }
            }
        }
    }
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public double HoursePower { get; set; }

        public Vehicle(string type, string model, string colour, double hoursepower)
        {
            Type = type;
            Model = model;
            Colour = colour;
            HoursePower = hoursepower;
        }

        public override string ToString()
        {
            string result = $"Type: {char.ToUpper(Type[0]) + Type.Substring(1)}\nModel: {Model}\nColor: {Colour}\nHorsepower: {HoursePower}";
            return result;
        }

    }
}

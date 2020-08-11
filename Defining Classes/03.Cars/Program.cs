using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _03.Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car(270, 2000, "3500", "BMW");
            Car nissan = new Car(300, 100000, "GT-2015", "Nissan");
            Car lada = new Car(60, 5000, "1500-S", "Lada");


            List<Car> cars = new List<Car>()
            {
                bmw,
                nissan,
                lada
            };

            foreach (var car in cars)
            {
                car.Drive();
            }

            var carsArr = new Car[] { bmw, nissan, lada };
            Console.WriteLine(carsArr[0].DisplayFullInfo);

        }

    }

    class Car
    {
        public int MaxSpeed { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }

        public string DisplayFullInfo
        {
            get
            {
                return $"I am {this.Brand} - {this.Model} and can reach {this.MaxSpeed} km/h";

            }
        }

        public Car(int maxSpeed, decimal price, string model, string brand)
        {
            this.MaxSpeed = maxSpeed;
            this.Price = price;
            this.Brand = brand;
            this.Model = model;
        }

        public void Drive()
        {
            Console.WriteLine($"I am {this.Brand} - {this.Model} and can reach {this.MaxSpeed} km/h");
        }

    }
}

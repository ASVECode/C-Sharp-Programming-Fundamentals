using System;
using System.Security.Cryptography;

namespace _01.DogsMeeting
{
    class Dog
    {
        //field declaration
        private string name;

        //constructor declaration
        public Dog()
        {
            this.name = "Balkan";
        }

        //another constructor declaration
        public Dog(string name)
        {
            this.name = name;
        }

        //proparty declaration 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //method declaration
        public void Bark()
        {
            Console.WriteLine(" {0} said: Wow-wow!", name);
        }
        static void Main(string[] args)
        {
            string firstDogName = null;
            Console.WriteLine("Write first dog name: ");
            firstDogName = Console.ReadLine();

            //using constructor to create dog with specified name
            Dog firstDog = new Dog(firstDogName);

            //using constructor to create doq with a default name
            Dog secondDog = new Dog();

            Console.WriteLine("Write the name of second dog: ");
            string secondDogName = Console.ReadLine();

            //using proparty to set the name of the dog
            secondDog.Name = secondDogName;

            //creating a dog with a default name
            Dog thirdDog = new Dog();

            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };
            foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
        }
    }
}

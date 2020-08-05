using System;
using System.Globalization;

namespace _01.Cat
{
    class Cat
    {
        //Field Name
        private string name;
        //Field colour
        private string color;

        public string Name
        {
            //Getter of the property "Name"
            get
            {
                return this.name;
            }
            //Setter of the proparty "Name"
            set
            {
                this.name = value;
            }

        }
        public string Color
        {
            //Getter of the proparty colour
            get
            {
                return this.color;
            }
            //Setter of the proparty colour
            set
            {
                this.color = value;
            }
        }

        //Default constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }
        //Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        //Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said Miauuuuu!", name);
        }
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.name = "Kitty";
            firstCat.SayMiau();

            Cat secondCat = new Cat("Pippy", "Red");
            secondCat.SayMiau();
            Console.WriteLine("Cat {0} is {1} .", secondCat.Name, secondCat.Color);
        }
    }
}

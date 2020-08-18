using System;
using System.Collections.Generic;
using System.Linq;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] tokens = Console.ReadLine().Split(separator: " ");

            while (tokens[0] != "End")
            {
                Person person = new Person(tokens[0], tokens[1], int.Parse(tokens[2]));
                people.Add(person);
                tokens = Console.ReadLine().Split(separator: " ");
            }
            people = people.OrderBy(a => a.Age).ToList();

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int Age)
        {
            this.Name = name;
            this.Age = Age;
            this.ID = id;
        }

        public override string ToString()
        {
            string result = $"{Name} with ID: {ID} is {Age} years old.";
            return result;
        }
    }
}

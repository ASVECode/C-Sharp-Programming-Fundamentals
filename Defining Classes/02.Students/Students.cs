using System;
using System.Data;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FirstName = "Pesho";
            student.LastName = "Vasilev";

            //string fullName = student.FullName;

            Console.WriteLine(student.FullName);
            student.LastName = "Kirov";
            Console.WriteLine(student.FullName);


        }


    }
    class Student
    {
        private string firstName;
        private string lastName;
        private const string University = "Sofia University";

        public string FirstName
        {
            set
            {
                if (value.Length > 3)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name should be longer than 3");
                }

            }
        }
        public string LastName
        {
            set
            {
                this.lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }
    }
}

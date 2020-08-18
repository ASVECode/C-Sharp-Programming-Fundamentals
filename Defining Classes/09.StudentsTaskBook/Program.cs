using System;
using System.Globalization;

namespace _09.StudentsTaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("name", "course", "program", "University", "email", "phone");
            student.FullInfo();
        }

    }
    class Student
    {
        private string fullName;
        private string course;
        private string program;
        private string university;
        private string email;
        private string phone;
        static int numObj;

        public Student(string fullName, string course, string program, string university, string email, string phone)
        {
            this.fullName = fullName;
            this.course = course;
            this.program = program;
            this.university = university;
            this.email = email;
            this.phone = phone;
        }

        public Student(string course)
          : this(course, "d", "d", "d", "d", "d")
        {
        }
        public void FullInfo()
        {
            Console.WriteLine($"{this.fullName} {this.phone} {this.course} {this.email}");
        }

    }


}



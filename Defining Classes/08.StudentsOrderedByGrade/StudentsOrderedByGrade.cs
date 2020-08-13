using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.StudentsOrderedByGrade
{
    class StudentsOrderedByGrade
    {
        public static object Serial { get; private set; }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(separator: " ");
                Student student = new Student(tokens[0], tokens[1], double.Parse(tokens[2]));
                students.Add(student);
            }
            // students= students.OrderByDesending(a => a.Grade).ToList();
            students.Sort((a, b) => b.Grade.CompareTo(a.Grade));
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }

        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}

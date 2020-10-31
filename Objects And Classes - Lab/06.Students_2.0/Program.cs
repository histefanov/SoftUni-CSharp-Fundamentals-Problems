using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentInfo = input.Split();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string homeTown = studentInfo[3];

                if (doesTheStudentExist(students, firstName, lastName))
                {
                    overwriteStudentInformation(students, studentInfo);
                }
                else
                {
                    students.Add(new Student(firstName, lastName, age, homeTown));
                }
            }

            string cityToCheck = Console.ReadLine();
            List<Student> studentsFiltered = students
                .Where(s => s.HomeTown == cityToCheck)
                .ToList();
            studentsFiltered.ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName} is {s.Age} years old."));
        }

        class Student
        {
            public Student(string firstName, string lastName, int age, string homeTown)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
                this.HomeTown = homeTown;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }

        static bool doesTheStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static void overwriteStudentInformation(List<Student> students, string[] studentInfo)
        {
            foreach (var student in students)
            {
                if (student.FirstName == studentInfo[0] && student.LastName == studentInfo[1])
                {
                    student.Age = int.Parse(studentInfo[2]);
                    student.HomeTown = studentInfo[3];
                    break;
                }
            }
        }
    }
}

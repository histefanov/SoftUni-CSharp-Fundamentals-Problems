using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students
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
                students.Add(new Student
                    (studentInfo[0], 
                     studentInfo[1], 
                     int.Parse(studentInfo[2]), 
                     studentInfo[3]));
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
    }
}

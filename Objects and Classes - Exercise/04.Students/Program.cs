using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                students.Add(new Student(
                    studentInfo[0],
                    studentInfo[1],
                    studentInfo[2]
                ));
            }

            PrintSortedByGrade(students);
        }

        class Student
        {
            public Student(string firstname, string secondname, string grade)
            {
                this.FirstName = firstname;
                this.SecondName = secondname;
                this.Grade = float.Parse(grade);
            }

            public string FirstName;
            public string SecondName;
            public float Grade;
        }

        static void PrintSortedByGrade(List<Student> students)
        {
            students
                .OrderBy(s => s.Grade)
                .Reverse()
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.SecondName}: {s.Grade:F2}"));
        }
    }
}

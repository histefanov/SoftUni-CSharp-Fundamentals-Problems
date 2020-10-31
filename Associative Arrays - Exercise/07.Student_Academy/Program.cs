using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>() { grade });
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }

            var studentsGradesFilteredAndSorted = studentGrades
                .Where(student => GetAverageGrade(student.Value) >= 4.50)
                .OrderByDescending(student => GetAverageGrade(student.Value))
                .ToDictionary(s => s.Key, s => s.Value);

            foreach (var kvp in studentsGradesFilteredAndSorted)
            {
                Console.WriteLine($"{kvp.Key} -> {GetAverageGrade(kvp.Value):F2}");
            }
        }

        static double GetAverageGrade(List<double> grades)
        {
            return grades.Sum() / grades.Count;
        }
    }
}

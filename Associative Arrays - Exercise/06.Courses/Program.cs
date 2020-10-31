using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputInfo = input.Split(" : ");
                string course = inputInfo[0];
                string studentName = inputInfo[1];

                if (courses.ContainsKey(course))
                {
                    courses[course].Add(studentName);
                }
                else
                {
                    courses.Add(course, new List<string>() { studentName });
                }
            }

            var coursesSorted = courses
                .OrderByDescending(c => c.Value.Count)
                .ToDictionary(c => c.Key, c => c.Value);

            foreach (var course in coursesSorted)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                course.Value
                    .OrderBy(name => name)
                    .ToList()
                    .ForEach(name => Console.WriteLine($"-- {name}"));
            }
        }
    }
}

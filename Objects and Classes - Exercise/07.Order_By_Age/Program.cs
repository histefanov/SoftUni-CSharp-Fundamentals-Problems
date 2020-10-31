using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Order_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> data = new List<Person>();

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] personalInfo = input.Split();
                data.Add(new Person(
                    personalInfo[0],
                    personalInfo[1],
                    personalInfo[2]
                ));
            }

            PrintOrderedByAge(data);
        }

        class Person
        {
            public Person(string name, string id, string age)
            {
                this.Name = name;
                this.ID = id;
                this.Age = int.Parse(age);
            }
            public string Name;
            public string ID;
            public int Age;
        }

        static void PrintOrderedByAge(List<Person> list)
        {
            list
                .OrderBy(p => p.Age)
                .ToList()
                .ForEach(p =>
                {
                    Console.WriteLine($"{p.Name} with ID: {p.ID} is {p.Age} years old.");
                });
        }
    }
}

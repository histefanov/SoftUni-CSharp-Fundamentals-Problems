using System;
using System.Collections.Generic;

namespace _09.Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(" -> ");
                string companyName = data[0];
                string employeeID = data[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>() { employeeID });
                }
                else if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }
            }

            foreach (var kvp in companies)
            {
                Console.WriteLine(kvp.Key);
                kvp.Value.ForEach(id => Console.WriteLine($"-- {id}"));
            }
        }
    }
}

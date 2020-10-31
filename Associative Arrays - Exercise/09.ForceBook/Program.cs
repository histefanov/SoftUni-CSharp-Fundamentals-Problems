using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceUsers = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains(" | "))
                {
                    string[] command = input.Split(" | ");
                    string forceSide = command[0];
                    string forceUser = command[1];

                    if (!forceUsers.ContainsKey(forceSide))
                    {
                        forceUsers.Add(forceSide, new List<string>());
                    }

                    if (!UserExists(forceUsers, forceUser))
                    {
                        forceUsers[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains(" -> "))
                {
                    string[] command = input.Split(" -> ");
                    string forceUser = command[0];
                    string forceSide = command[1];

                    if (!forceUsers.ContainsKey(forceSide))
                    {
                        forceUsers.Add(forceSide, new List<string>());
                    }

                    if (UserExists(forceUsers, forceUser))
                    {
                        forceUsers[GetUsersForce(forceUsers, forceUser)].Remove(forceUser);
                    }

                    forceUsers[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            PrintForceUsersInfo(forceUsers);
        }

        static bool UserExists(Dictionary<string, List<string>> dict, string user)
        {
            foreach (var kvp in dict)
            {
                if (kvp.Value.Contains(user))
                {
                    return true;
                }
            }
            return false;
        }

        static string GetUsersForce(Dictionary<string, List<string>> dict, string user)
        {
            foreach (var kvp in dict)
            {
                if (kvp.Value.Contains(user))
                {
                    return kvp.Key;
                }
            }
            return "User not found!";
        }

        static void PrintForceUsersInfo(Dictionary<string, List<string>> dict)
        {
            dict = dict
                .Where(kvp => kvp.Value.Count > 0)
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in dict)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                kvp.Value
                    .OrderBy(user => user)
                    .ToList()
                    .ForEach(user => Console.WriteLine($"! {user}"));
            }
        }
    }
}

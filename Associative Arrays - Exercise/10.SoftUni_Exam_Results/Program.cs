using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, byte> participants = new Dictionary<string, byte>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] submissionData = input.Split('-');
                string username = submissionData[0];

                if (submissionData[1] == "banned")
                {
                    participants.Remove(username);
                    continue;
                }

                string language = submissionData[1];
                byte points = byte.Parse(submissionData[2]);

                if (!participants.ContainsKey(username))
                {
                    participants.Add(username, points);
                }
                else if (participants[username] < points)
                {
                    participants[username] = points;
                }

                if (!submissions.ContainsKey(language))
                {
                    submissions.Add(language, 1);
                }
                else
                {
                    submissions[language]++;
                }
            }

            PrintParticipants(participants);
            PrintSubmissions(submissions);
        }

        static void PrintParticipants(Dictionary<string, byte> dict)
        {
            Console.WriteLine("Results:");
            dict = dict
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
        }
        static void PrintSubmissions(Dictionary<string, int> dict)
        {
            Console.WriteLine("Submissions:");
            dict = dict
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}

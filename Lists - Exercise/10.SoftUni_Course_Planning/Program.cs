using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] commandInfo = command.Split(':');
                string action = commandInfo[0];
                string lessonTitle = commandInfo[1];

                switch (action)
                {
                    case "Add":
                        if (!schedule.Contains(lessonTitle))
                        {
                            schedule.Add(lessonTitle);
                        }
                        break;

                    case "Insert":
                        int index = int.Parse(commandInfo[2]);

                        if (!schedule.Contains(lessonTitle))
                        {
                            schedule.Insert(index, lessonTitle);
                        }
                        break;

                    case "Remove":
                        if (schedule.Contains(lessonTitle))
                        {
                            schedule.Remove(lessonTitle);

                            if (schedule.Contains($"{lessonTitle}-Exercise"))
                            {
                                schedule.Remove($"{lessonTitle}-Exercise");
                            }
                        }
                        break;

                    case "Swap":
                        string lessonTitleTwo = commandInfo[2];
                        if (schedule.Contains(lessonTitle) && schedule.Contains(lessonTitleTwo))
                        {
                            int indexOne = schedule.IndexOf(lessonTitle);
                            int indexTwo = schedule.IndexOf(lessonTitleTwo);
                            schedule[indexOne] = lessonTitleTwo;
                            schedule[indexTwo] = lessonTitle;

                            if (schedule.Contains($"{lessonTitle}-Exercise"))
                            {
                                schedule.Remove($"{lessonTitle}-Exercise");
                                schedule.Insert(indexTwo + 1, $"{lessonTitle}-Exercise");
                            }
                            if (schedule.Contains($"{lessonTitleTwo}-Exercise"))
                            {
                                schedule.Remove($"{lessonTitleTwo}-Exercise");
                                schedule.Insert(indexOne + 1, $"{lessonTitleTwo}-Exercise");
                            }
                        }
                        break;

                    case "Exercise":
                        string exercise = $"{lessonTitle}-Exercise";
                        if (!schedule.Contains(exercise))
                        {
                            if (schedule.Contains(lessonTitle))
                            {
                                schedule.Insert(schedule.IndexOf(lessonTitle) + 1, exercise);
                            }
                            else
                            {
                                schedule.Add(lessonTitle);
                                schedule.Add(exercise);
                            }
                        }
                        break;
                }
            }
            schedule.ForEach(lesson =>
                Console.WriteLine($"{schedule.IndexOf(lesson) + 1}.{lesson}"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "merge")
                {
                    int startIndex = Math.Max(0, int.Parse(tokens[1]));
                    int endIndex = Math.Min(data.Count - 1, int.Parse(tokens[2]));

                    if (startIndex < data.Count - 1)
                    {
                        StringBuilder mergeResult = new StringBuilder();

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            mergeResult.Append(data[i]);
                        }

                        data.RemoveRange(startIndex, endIndex - startIndex + 1);
                        data.Insert(startIndex, mergeResult.ToString());
                    }
                }

                else if (command == "divide")
                {
                    int index = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);
                    string item = data[index];
                    data.RemoveAt(index);

                    int partitionLength = item.Length / partitions;
                    int currentItemIndex = 0;

                    for (int i = 1; i < partitions; i++)
                    {
                        string part = item.Substring(currentItemIndex, partitionLength);
                        data.Insert(index, part);
                        currentItemIndex += partitionLength;
                        index++;
                    }

                    string finalPart = item.Substring(currentItemIndex, partitionLength + item.Length % partitions);
                    data.Insert(index, finalPart);
                }
            }
            Console.WriteLine(string.Join(' ', data));
        }
    }
}

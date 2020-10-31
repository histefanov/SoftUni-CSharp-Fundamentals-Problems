using System;
using System.Linq;

namespace _10.Lady_Bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[fieldSize];

            foreach (var index in ladybugIndexes)
            {
                if (index >= 0 && index < fieldSize)
                {
                    field[index] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                int index = int.Parse(tokens[0]);

                if (index >= 0 && index < fieldSize && field[index] == 1 && index >= 0 && index < fieldSize)
                {
                    field[index] = 0;
                    string direction = tokens[1];
                    int flyLength = int.Parse(tokens[2]);
                    bool hasLanded = false;

                    if (direction == "right")
                    {
                        while (!hasLanded)
                        {
                            if (index + flyLength < fieldSize && index + flyLength >= 0)
                            {
                                if (field[index + flyLength] == 0)
                                {
                                    field[index + flyLength] = 1;
                                    hasLanded = true;
                                }
                                else
                                {
                                    index += flyLength;
                                }
                            }
                            else
                            {
                                hasLanded = true;
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        while (!hasLanded)
                        {
                            if (index - flyLength < fieldSize && index - flyLength >= 0)
                            {
                                if (field[index - flyLength] == 0)
                                {
                                    field[index - flyLength] = 1;
                                    hasLanded = true;
                                }
                                else
                                {
                                    index -= flyLength;
                                }
                            }
                            else
                            {
                                hasLanded = true;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}

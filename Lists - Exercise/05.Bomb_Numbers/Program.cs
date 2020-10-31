using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombInfo[0];
            int bombPower = bombInfo[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    for (int l = i - 1; l >= Math.Max(0, i - bombPower); l--)
                    {
                        numbers[l] = 0;
                    }

                    for (int r = i; r <= Math.Min(numbers.Count - 1, i + bombPower); r++)
                    {
                        numbers[r] = 0;
                    }

                    i += bombPower - 1;
                }
            }

            Console.WriteLine(numbers.Aggregate(0, (total, next) => total + next));
        }
    }
}

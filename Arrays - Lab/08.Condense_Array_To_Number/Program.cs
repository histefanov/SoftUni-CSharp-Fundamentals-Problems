using System;
using System.Linq;

namespace _08.Condense_Array_To_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (numbers.Length > 1)
            {
                var index = 0;
                int[] condesedNums = new int[numbers.Length - 1];

                while (index < numbers.Length - 1)
                {
                    condesedNums[index] = numbers[index] + numbers[index + 1];
                    index++;
                }

                numbers = (int[])condesedNums.Clone();
            }

            Console.WriteLine(numbers[0]);
        }
    }
}


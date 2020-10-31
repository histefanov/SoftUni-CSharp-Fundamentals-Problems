using System;

namespace _05.Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numsAsString = Console.ReadLine().Split();
            var sum = 0;

            for (int i = 0; i < numsAsString.Length; i++)
            {
                int currentNum = int.Parse(numsAsString[i]);

                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

using System;

namespace _6.Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var currentDigit = 0;
            var facSum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                currentDigit = int.Parse(num[i].ToString());

                if (currentDigit == 0)
                {
                    facSum += 1;
                    continue;
                }

                for (int j = currentDigit - 1; j >= 1; j--)
                {
                    currentDigit *= j;
                }

                facSum += currentDigit;
            }

            if (int.Parse(num) == facSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

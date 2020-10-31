using System;

namespace _10.Multiply_Evens_By_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvensAndOdds(GetSumOfOddDigits(num), GetSumOfEvenDigits(num)));
        }

        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int currentDigit = num % 10;

                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
                num /= 10;
            }
            return sum;
        }
        
        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int currentDigit = num % 10;

                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }
                num /= 10;
            }
            return sum;
        }

        static int GetMultipleOfEvensAndOdds(int oddSum, int evenSum)
        {
            return oddSum * evenSum;
        }

    }
}

using System;
using System.Numerics;

namespace More_02.From_Left_To_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                string[] numsArr = input.Split(" ");
                BigInteger leftNum = BigInteger.Parse(numsArr[0].ToString());
                BigInteger rightNum = BigInteger.Parse(numsArr[1].ToString());
                string biggerNum = BigInteger.Abs(BigInteger.Max(leftNum, rightNum)).ToString();

                for (int j = 0; j < biggerNum.Length; j++)
                {
                    sum += int.Parse(biggerNum[j].ToString());
                }

                Console.WriteLine(sum);
            }
        }
    }
}
using System;

namespace _02.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digitSum = 0;
            while (num > 0)
            {
                digitSum += num % 10;
                num /= 10;
            }
            Console.WriteLine(digitSum);
        }
    }
}

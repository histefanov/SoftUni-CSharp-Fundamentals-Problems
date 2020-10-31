using System;
using System.Collections;

namespace _4.Print_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            var nums = "";
            var sum = 0;

            for (int i = startNum; i <= endNum; i++)
            {
                nums += i + " ";
                sum += i;
            }

            Console.WriteLine($"{nums}\nSum: {sum}");
        }
    }
}

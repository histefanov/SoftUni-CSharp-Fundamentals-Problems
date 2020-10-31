using System;
using System.Linq;
using System.Text;

namespace _05.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            int remainder = 0;
            StringBuilder result = new StringBuilder();

            while (num.StartsWith('0'))
            {
                num = num.Substring(1);
            }

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = num.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(num[i].ToString());
                int resultDigit = (currentDigit * multiplier + remainder) % 10;
                remainder = (currentDigit * multiplier + remainder) / 10;
                result.Insert(0, resultDigit);
            }

            if (remainder > 0)
            {
                result.Insert(0, remainder);
            }
            Console.WriteLine(result.ToString());
        }
    }
}

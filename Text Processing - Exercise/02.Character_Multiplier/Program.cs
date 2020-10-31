using System;

namespace _02.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string str1 = strings[0];
            string str2 = strings[1];
            int sum = 0;

            for (int i = 0; i < Math.Max(str1.Length, str2.Length); i++)
            {
                if (i < str1.Length && i < str2.Length)
                {
                    sum += str1[i] * str2[i];
                }
                else
                {
                    if (str1.Length > str2.Length)
                    {
                        sum += str1[i];
                    }
                    else
                    {
                        sum += str2[i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}

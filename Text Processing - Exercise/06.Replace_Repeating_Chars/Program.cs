using System;

namespace _06.Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int currentLength = str.Length;

            for (int i = 0; i < currentLength - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    str = str.Substring(0, i + 1) + str.Substring(i + 2);
                    currentLength = str.Length;
                    i--;
                }
            }

            Console.WriteLine(str);
        }
    }
}

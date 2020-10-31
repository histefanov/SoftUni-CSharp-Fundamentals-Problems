using System;

namespace _07.Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string res = StringRepeater(str, n);
            Console.WriteLine(res);
        }

        static string StringRepeater(string str, int repetitions)
        {
            string res = "";
            for (int i = 0; i < repetitions; i++)
            {
                res += str;
            }
            return res;
        }
    }
}

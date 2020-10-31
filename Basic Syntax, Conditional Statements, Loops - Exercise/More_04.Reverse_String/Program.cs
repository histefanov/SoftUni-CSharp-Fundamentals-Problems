using System;

namespace More_04.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string res = "";

            for (int i = str.Length - 1; i > -1; i--)
            {
                res += str[i];
            }

            Console.WriteLine(res);
        }
    }
}

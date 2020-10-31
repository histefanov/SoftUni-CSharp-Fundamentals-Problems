using System;

namespace _8.Triangle_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var line = "";

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    line += i + " ";
                }

                Console.WriteLine(line);
                line = "";
            }
        }
    }
}

using System;

namespace More_1.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            var res = "";

            if (a >= b && a >= c)
            {
                res += a + "\n";

                if (b >= c)
                {
                    res += b + "\n" + c;
                }
                else
                {
                    res += c + "\n" + b;
                }
            }
            else if (b >= a && b >= c)
            {
                res += b + "\n";

                if (a >= c)
                {
                    res += a + "\n" + c;
                }
                else
                {
                    res += c + "\n" + a;
                }
            }
            else
            {
                res += c + "\n";
                if (a >= b)
                {
                    res += a + "\n" + b;
                }
                else
                {
                    res += b + "\n" + a;
                }
            }

            Console.WriteLine(res);
        }
    }
}

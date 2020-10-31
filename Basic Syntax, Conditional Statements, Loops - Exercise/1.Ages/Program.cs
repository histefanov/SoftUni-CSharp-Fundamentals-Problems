using System;

namespace _01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var res = "";

            if (age >= 0 && age <= 2)
            {
                res = "baby";
            }
            else if (age > 2 && age <= 13)
            {
                res = "child";
            }
            else if (age > 13 && age <= 19)
            {
                res = "teenager";
            }
            else if (age > 19 && age <= 65)
            {
                res = "adult";
            }
            else if (age > 65)
            {
                res = "elder";
            }

            Console.WriteLine(res);
        }
    }
}

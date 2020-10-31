using System;
using System.Text;

namespace _05.Digits__Letters_and_Others
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            string str = Console.ReadLine();

            foreach (var ch in str)
            {
                if (ch >= '0' && ch <= '9')
                {
                    digits.Append(ch);
                }
                else if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                {
                    letters.Append(ch);
                }
                else
                {
                    others.Append(ch);
                }
            }

            Console.WriteLine($"{digits.ToString()}\n{letters.ToString()}\n{others.ToString()}");

        }
    }
}

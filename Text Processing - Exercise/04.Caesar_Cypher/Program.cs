using System;
using System.Text;

namespace _04.Caesar_Cypher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder cipher = new StringBuilder();
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                cipher.Append((char)(str[i] + 3));
            }

            Console.WriteLine(cipher.ToString());
        }
    }
}

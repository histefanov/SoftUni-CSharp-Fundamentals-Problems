using System;

namespace More_05.Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string res = String.Empty;

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                res += (char)(ch + key);
            }

            Console.WriteLine(res);
        }
    }
}

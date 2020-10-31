using System;

namespace More_05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int input = 0;
            int mainDigit = 0;
            int length = 0;
            int offset = 0;
            int index = 0;
            string res = "";
            

            for (int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    res += " ";
                    continue;
                }
                mainDigit = input.ToString()[0] - '0';
                length = input.ToString().Length;
                offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                index = (offset + length - 1);
                res += Convert.ToChar(97 + index);
            }

            Console.WriteLine(res);
        }
    }
}

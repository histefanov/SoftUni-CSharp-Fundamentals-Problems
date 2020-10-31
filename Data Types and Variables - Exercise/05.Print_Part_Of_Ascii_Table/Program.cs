using System;

namespace _05.Print_Part_Of_Ascii_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startCode = int.Parse(Console.ReadLine());
            int endCode = int.Parse(Console.ReadLine());
            for (int i = startCode; i <= endCode; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}

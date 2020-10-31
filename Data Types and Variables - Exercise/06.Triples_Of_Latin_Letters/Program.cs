using System;

namespace _06.Triples_Of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char charOne = (char)('a' + i);
                for (int j = 0; j < n; j++)
                {
                    char charTwo = (char)('a' + j);
                    for (int k = 0; k < n; k++)
                    {
                        char charThree = (char)('a' + k);
                        Console.WriteLine("{0}{1}{2}", charOne, charTwo, charThree);
                    }
                }
            }
        }
    }
}

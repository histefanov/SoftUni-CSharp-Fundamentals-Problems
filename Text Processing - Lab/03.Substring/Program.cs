using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string substr = Console.ReadLine();
            string sequence = Console.ReadLine();

            while (sequence.Contains(substr))
            {
                int index = sequence.IndexOf(substr);
                sequence = sequence.Remove(index, substr.Length);
            }

            Console.WriteLine(sequence);
        }
    }
}

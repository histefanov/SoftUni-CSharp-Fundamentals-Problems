using System;
using System.Linq;

namespace _02.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();
            string commonItems = String.Empty;

            foreach (var item in arrTwo)
            {
                if (arrOne.Contains(item))
                {
                    commonItems += item + " ";
                }
            }

            Console.WriteLine(commonItems);
        }
    }
}

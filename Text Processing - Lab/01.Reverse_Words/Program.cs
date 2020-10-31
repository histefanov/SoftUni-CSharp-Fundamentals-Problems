using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            while ((word = Console.ReadLine()) != "end")
            {
                Console.WriteLine(word + " = " + string.Join("", word.Reverse()));
            }
        }
    }
}

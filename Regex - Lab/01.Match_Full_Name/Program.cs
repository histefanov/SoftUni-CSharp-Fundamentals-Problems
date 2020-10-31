using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Z][a-z]+ [A-Z][a-z]+";
            MatchCollection matchedNames = Regex.Matches(Console.ReadLine(), pattern);

            foreach (Match name in matchedNames)
            {
                Console.Write(name + " ");
            }
        }
    }
}

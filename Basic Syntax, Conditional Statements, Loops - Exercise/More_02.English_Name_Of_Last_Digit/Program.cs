using System;

namespace More_02.English_Name_Of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var numAsString = Console.ReadLine();
            string[] names = { "zero", "one", "two", "three", 
                               "four", "five", "six", 
                               "seven", "eight", "nine" };
            var index = int.Parse(numAsString[^1].ToString());
            Console.WriteLine(names[index]);
        }
    }
}

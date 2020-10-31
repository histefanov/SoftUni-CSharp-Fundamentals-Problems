using System;

namespace _6.Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());
            char charThree = char.Parse(Console.ReadLine());

            string res = charThree + " " + charTwo + " " + charOne;
            Console.WriteLine(res); ;
        }
    }
}

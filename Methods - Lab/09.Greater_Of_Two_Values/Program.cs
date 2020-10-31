using System;

namespace _09.Greater_Of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
        }

        static string GetMax(string type, string valueOne, string valueTwo)
        {
            if (type == "int")
            {
                int numOne = int.Parse(valueOne);
                int numTwo = int.Parse(valueTwo);
                return Math.Max(numOne, numTwo).ToString();
            }

            else if (type == "char")
            {
                char a = char.Parse(valueOne);
                char b = char.Parse(valueTwo);
                if ((int)a > (int)b)
                {
                    return valueOne;
                }
                else
                {
                    return valueTwo;
                }
            }

            else
            {
                int comparison = valueOne.CompareTo(valueTwo);
                if (comparison > 0)
                {
                    return valueOne;
                }
                else
                {
                    return valueTwo;
                }
            }
        }
    }
}

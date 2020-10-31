using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            switch (command)
            {
                case "add": Add(a, b); break;
                case "multiply": Multiply(a, b); break;
                case "subtract": Subtract(a, b); break;
                case "divide": Divide(a, b); break;
            }
        }

        static void Add(double numOne, double numTwo)
        {
            Console.WriteLine(numOne + numTwo);
        }

        static void Multiply(double numOne, double numTwo)
        {
            Console.WriteLine(numOne * numTwo);
        }

        static void Subtract(double numOne, double numTwo)
        {
            Console.WriteLine(numOne - numTwo);
        }

        static void Divide(double numOne, double numTwo)
        {
            Console.WriteLine(numOne / numTwo);
        }
    }
}

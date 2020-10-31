using System;

namespace _11.Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double result = Calculate(firstNum, op, secondNum);
            Console.WriteLine(result);
        }

        static double Calculate(double firstNum, char op, double secondNum)
        {
            switch (op)
            {
                case '+': return firstNum + secondNum;
                case '-': return firstNum - secondNum;
                case '*': return firstNum * secondNum;
                case '/': return firstNum / secondNum;
                default:
                    return 0;
            }
        }
    }
}

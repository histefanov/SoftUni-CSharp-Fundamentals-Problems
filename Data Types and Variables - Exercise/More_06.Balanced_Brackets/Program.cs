using System;

namespace More_06.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isBalanced = true;
            bool isOpen = false;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (!isOpen)
                    {
                        isOpen = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
                else if (input == ")")
                {
                    if (isOpen)
                    {
                        isOpen = false;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }
            Console.WriteLine((isBalanced && !isOpen) ? "BALANCED" : "UNBALANCED");
        }
    }
}

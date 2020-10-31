using System;

namespace More_02.Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int[] topArr = { 1 };
            Console.WriteLine("1");

            for (int i = 1; i < n; i++)
            {
                int[] bottomArr = new int[topArr.Length + 1];

                for (int j = 0; j < bottomArr.Length; j++)
                {
                    if (j - 1 >= 0)
                    {
                        bottomArr[j] += topArr[j - 1];
                    }
                    if (j < topArr.Length)
                    {
                        bottomArr[j] += topArr[j];
                    }
                }
                Console.WriteLine(String.Join(" ", bottomArr));
                topArr = bottomArr;
            }
        }
    }
}

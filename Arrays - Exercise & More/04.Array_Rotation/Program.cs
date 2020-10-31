using System;

namespace _04.Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n % arr.Length; i++)
            {
                string[] temp = new string[arr.Length];

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    temp[j] = arr[j + 1];
                }

                temp[^1] = arr[0];
                arr = temp;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}

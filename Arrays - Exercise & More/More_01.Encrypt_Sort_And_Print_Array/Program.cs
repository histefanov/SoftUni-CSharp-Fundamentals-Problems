using System;
using System.Linq;

namespace More_01.Encrypt_Sort_And_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] arr = new int[lines];
            char[] vowels = { 'a', 'A', 'e', 'E', 'o', 'O', 'u', 'U', 'i', 'I' };

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                int res = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (vowels.Contains(input[j]))
                    {
                        res += (char)input[j] * input.Length;
                    }
                    else
                    {
                        res += (char)input[j] / input.Length;
                    }
                }

                arr[i] = res;
            }

            Array.Sort(arr);
            Console.WriteLine(String.Join("\n", arr));
        }
    }
}

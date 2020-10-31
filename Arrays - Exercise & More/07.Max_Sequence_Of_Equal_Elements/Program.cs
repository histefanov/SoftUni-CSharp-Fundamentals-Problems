using System;

namespace _07.Max_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string longestYet = arr[0] + " ";

            for (int i = 0; i < arr.Length; i++)
            {
                string temp = arr[i] + " ";

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        temp += arr[i] + " ";
                    }
                    else
                    {
                        break;
                    }
                }

                if (temp.Length > longestYet.Length)
                {
                    longestYet = temp;
                }
            }

            Console.WriteLine(longestYet.Trim());
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var name in usernames)
            {
                bool hasValidLength = name.Length >= 3 && name.Length <= 16;
                if (hasValidLength && ContainsValidChars(name))
                {
                    Console.WriteLine(name);
                }
            }
        }

        static bool ContainsValidChars(string name)
        {
            foreach (var ch in name)
            {             
                if ((ch >= 'a' && ch <= 'z') || 
                    (ch >= 'A' && ch <= 'Z') || 
                    (ch >= '0' && ch <= '9') || 
                     ch == '-' || ch == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}

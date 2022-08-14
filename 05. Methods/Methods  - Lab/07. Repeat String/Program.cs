using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintString(str, n));
        }
        static string PrintString(string str, int n)
        {
            string result = "";

            for (int i = 0; i < n; i++)
            {
                result += str;
            }
            return result;
        }
    }
}

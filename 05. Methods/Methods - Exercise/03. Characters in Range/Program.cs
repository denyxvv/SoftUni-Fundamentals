using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            PrintCharsBetween(char1, char2);
        }
        static void PrintCharsBetween(int char1, int char2)
        {
            int startchar = Math.Min(char1, char2);
            int endchar = Math.Max(char1, char2);

            for (int i = startchar + 1; i < endchar; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
            }
        }
    }
}

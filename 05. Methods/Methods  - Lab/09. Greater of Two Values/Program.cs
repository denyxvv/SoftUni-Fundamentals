using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(first, second));
                    break;
                case "char":
                    char charfirst = char.Parse(Console.ReadLine());
                    char charsecond = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(charfirst, charsecond));
                    break;
                case "string":
                    string stringfirst = Console.ReadLine();
                    string stringsecond = Console.ReadLine();
                    Console.WriteLine(GetMax(stringfirst, stringsecond));
                    break;
                default:
                    break;
            }
        }
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string first, string second)
        {
            first.CompareTo(second);
            return second;
        }
    }
}

using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string something = Console.ReadLine();
            PrintMiddleChar(something);
        }

        static void PrintMiddleChar(string something)
        {
            if (something.Length % 2 == 0)
            {
                Console.Write(something[something.Length / 2 - 1]);
                Console.WriteLine(something[something.Length / 2]);
            }
            else
            {
                Console.WriteLine(something[something.Length / 2]);
            }
        }
    }
}

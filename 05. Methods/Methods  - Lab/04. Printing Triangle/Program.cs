using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                PrintLines(1, i);  
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLines(1, i);
            }
         
            
        }
        static void PrintLines(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        
    }
}

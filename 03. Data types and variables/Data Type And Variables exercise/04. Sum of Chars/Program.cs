﻿using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int finalsum = 0;
            for (int i = 0; i < n; i++)
            {
                char digit = char.Parse(Console.ReadLine());
                finalsum += (int)digit;
            }
            Console.WriteLine($"The sum equals: {finalsum}");
        }
    }
}

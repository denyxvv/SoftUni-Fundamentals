﻿using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNxNMatrix(n);
        }

        static void PrintNxNMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                Console.Write($"{number} ");

                }
                Console.WriteLine();
            }
        }
    }
}

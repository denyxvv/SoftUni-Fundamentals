using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();

            int nLines = int.Parse(Console.ReadLine());
                

            for (int i = 0; i < nLines; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();
            for (int i = 0; i < nLines; i++)
            {
            Console.WriteLine($"{i + 1}.{products[i]}");

            }
        }
    }
}

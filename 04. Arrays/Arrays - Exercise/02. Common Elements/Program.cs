using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ");
            string[] arr2 = Console.ReadLine().Split(" ");

            foreach (string currentElement in arr1)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    string secondElement = arr2[i];
                    if (currentElement == secondElement)
                    {
                        Console.Write($"{currentElement} ");
                        break;
                    }

                }
            }

        }
    }
}

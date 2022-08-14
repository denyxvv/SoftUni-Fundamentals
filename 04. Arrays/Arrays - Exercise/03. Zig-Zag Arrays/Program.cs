using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int[] arr1 = new int[nLines];
            int[] arr2 = new int[nLines];

            for (int i = 0; i < nLines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = numbers[0];
                    arr2[i] = numbers[1];
                }
                else
                {
                    arr1[i] = numbers[1];
                    arr2[i] = numbers[0];
                }

            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));

        }
    }
}

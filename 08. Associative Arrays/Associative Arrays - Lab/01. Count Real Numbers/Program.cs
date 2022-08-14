using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> sameNumsTyped = new SortedDictionary<int, int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var num in numbers)
            {
                if (sameNumsTyped.ContainsKey(num))
                {
                  
                    sameNumsTyped[num] ++;
                }
                else
                {
                    sameNumsTyped.Add(num, 1);
                }
            }

            foreach (var nums in sameNumsTyped)
            {
                Console.WriteLine($"{nums.Key} -> {nums.Value}");
            }

        }
    }
}

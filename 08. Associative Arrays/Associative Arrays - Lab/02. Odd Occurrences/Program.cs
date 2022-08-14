using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string lowerCase = word.ToLower();

                if (counts.ContainsKey(lowerCase))
                {
                    counts[lowerCase]++;
                }
                else
                {
                    counts.Add(lowerCase, 1);
                }
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write($"{count.Key} ");
                }
            }
        }
    }
}

using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
           PrintVowelCount(str);
        }

        static void PrintVowelCount(string text)
        {
            int count = 0;
            foreach  (char vowel in text)
            {
                if ("aouei".Contains(vowel))
                {
                count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

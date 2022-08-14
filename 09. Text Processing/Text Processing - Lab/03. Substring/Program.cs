using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string fullString = Console.ReadLine();

            while (fullString.Contains(wordToRemove))
            {
                fullString = fullString.Replace(wordToRemove, "");  
            }
           Console.WriteLine(fullString);
        }
    }
}

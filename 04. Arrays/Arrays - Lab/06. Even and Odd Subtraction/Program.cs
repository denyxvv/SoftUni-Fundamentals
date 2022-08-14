using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;

            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumOfEvenNumbers += number;
                }
                else 
                {
                    sumOfOddNumbers += number;
                }
            }
            Console.WriteLine(sumOfEvenNumbers - sumOfOddNumbers);
        }
    }
}

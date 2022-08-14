using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            int OddSum = SumOfOddDigits(n);
            int EvenSum = SumOfEvenDigits(n);
            Console.WriteLine(OddAndEvenMultiplied(OddSum, EvenSum));
        }
        static int SumOfEvenDigits(int n)
        {
            int EvenSum = 0;
            int digit = n;
            while (digit > 0)
            {
                int currentdigit = digit % 10;
                if (currentdigit % 2 == 0)
                {
                    EvenSum += currentdigit;
                }
                digit /= 10;
            }
                    return EvenSum;
        }
        static int SumOfOddDigits(int n)
        {
            int OddSum = 0;
            int digit = n;
            while (digit > 0)
            {
                int currentdigit = digit % 10;
                if (currentdigit % 2 != 0)
                {
                    OddSum += currentdigit;
                }
                digit /= 10;
            }
            return OddSum;
        }
        static int OddAndEvenMultiplied(int OddSum, int EvenSum)
        {
            return OddSum * EvenSum;
        }
            
    }
}

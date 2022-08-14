using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int calc1 = 0;
            int sum = 0;

            while (firstNumber > 0)
            {
                calc1 = firstNumber % 10;
                sum += calc1;
                firstNumber /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}

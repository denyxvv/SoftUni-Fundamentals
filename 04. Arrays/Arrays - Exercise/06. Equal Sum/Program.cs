using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftsum = 0;
            int rightsum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1 )
                {
                    Console.WriteLine(0);
                    return;
                }
                leftsum = 0;
                for (int leftsum2 = i; leftsum2 > 0; leftsum2--)
                {
                    int nextLeftPosition = leftsum2 - 1;
                    if (leftsum2 > 0)
                    {
                        leftsum += numbers[nextLeftPosition];
                    }
                }
                rightsum = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    int nextRightPosition = j + 1;
                    if (j < numbers.Length - 1)
                    {
                        rightsum += numbers[nextRightPosition];
                    }
                }

                if (rightsum == leftsum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}

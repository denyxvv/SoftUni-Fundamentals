using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            double[] numbers = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = double.Parse(nums[i]);
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine($"{numbers[j]} => {(int)Math.Round(numbers[j], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

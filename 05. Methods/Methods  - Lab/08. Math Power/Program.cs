using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1 = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintBasePower(base1, power));
        }
        static double PrintBasePower(double base1, int power)
        {
            return Math.Pow(base1, power);
        }
    }
}

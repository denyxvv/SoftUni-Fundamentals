using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int nLines = int.Parse(Console.ReadLine());
            int currentCapacity = CAPACITY;

            for (int i = 0; i < nLines; i++)
            {
                int litresInput = int.Parse(Console.ReadLine());
                if (currentCapacity - litresInput >= 0)
                {
                    currentCapacity -= litresInput;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            int totalFilled = CAPACITY - currentCapacity;
            Console.WriteLine(totalFilled);
        }
    }
}

using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int nWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[nWagons];

            int peopleOnTrain = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                peopleOnTrain += wagons[i];
            }
            foreach (int wagon in wagons)
            {
                Console.Write($"{wagon} ");

            }
           
            Console.WriteLine();
            Console.WriteLine(peopleOnTrain);

           
        }
    }
}

using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            double biggestKeg = double.MinValue;
            string biggestKegName = "";

            for (int i = 0; i < nLines; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * height;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestKegName = model;

                }

            }
            Console.WriteLine(biggestKegName);
        }
    }
}

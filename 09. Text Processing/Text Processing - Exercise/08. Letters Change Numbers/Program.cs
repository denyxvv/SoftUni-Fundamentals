using System;
using System.Collections.Generic;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var item in line)
            {

                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1]; 

                int firstAlphabetPosition = char.ToUpper(firstLetter) - 64;
                int lastAlphabetPosition = char.ToUpper(lastLetter) - 64;

                double number = double.Parse(item.Substring(1, item.Length - 2));

                double result = 0;
                
                if (char.IsUpper(firstLetter))
                {
                    result = number / firstAlphabetPosition;
                }
                else
                {
                    result = number * firstAlphabetPosition;
                }

                if (char.IsUpper(lastLetter))
                {
                    sum += result - lastAlphabetPosition;               
                }
                else
                {
                    sum += result + lastAlphabetPosition;
                }

            }

            Console.WriteLine($"{sum:f2}");

            
        }
    }
}

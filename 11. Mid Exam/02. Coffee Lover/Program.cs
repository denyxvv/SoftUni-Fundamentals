using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine().Split().ToList();
            int nCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < nCommands; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Include":
                        string coffeeToInclude = tokens[1];
                        coffees.Add(coffeeToInclude);
                        break;

                    case "Remove":
                        int numberOfCoffees = int.Parse(tokens[2]);
                        if (coffees.Count < numberOfCoffees)
                        {
                            break;
                        }

                        if (tokens[1] == "first")
                        {
                            for (int j = 0; j < numberOfCoffees; j++)
                            {
                                coffees.RemoveAt(0);
                            }
                        }

                        if (tokens[1] == "last")
                        {
                            for (int j = 0; j < numberOfCoffees; j++)
                            {
                                coffees.RemoveAt(coffees.Count - 1);
                            }
                        }
                        break;
                    case "Prefer":
                        int coffeeIndex = int.Parse(tokens[1]);
                        int coffeeIndex2 = int.Parse(tokens[2]);

                        if (coffeeIndex >= 0 && coffeeIndex <= coffees.Count - 1 && coffeeIndex2 >= 0 && coffeeIndex2 <= coffees.Count - 1 )
                        {
                            Swap(coffeeIndex, coffeeIndex2, coffees);
                            
                        }
                        break;
                    case "Reverse":
                        coffees.Reverse();
                        break;

                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(' ', coffees));


        }
        static void Swap(int firstIndex, int secondIndex, List<string> numbers)
        {
            string temp = numbers[firstIndex]; ;
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }
    }
}

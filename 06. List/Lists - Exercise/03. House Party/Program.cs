using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            var listOfNames = new List<string>();

            for (int i = 0; i < nLines; i++)
            {
                var command = Console.ReadLine().Split();
                string currName = command[0];
                if (listOfNames.Contains(command[0]) && command[2] == "going!")
                {
                    Console.WriteLine($"{command[0]} is already in the list!");
                }
                else if (listOfNames.Contains(command[0]) && command[2] == "not")
                {
                    listOfNames.Remove(currName);
                }
                else if (!listOfNames.Contains(command[0]) && command[2] == "not")
                {
                    Console.WriteLine($"{currName} is not in the list!");
                }
                else
                {
                    listOfNames.Add(currName);
                }
            }
            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

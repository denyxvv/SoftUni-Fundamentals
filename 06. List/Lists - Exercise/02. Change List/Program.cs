using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                switch (tokens[0])
                {
                    case "Delete":
                        int number = int.Parse(tokens[1]);
                        numbers.RemoveAll(item => item == number);
                        break;
                    case "Insert":
                        int element = int.Parse(tokens[1]);
                        int position = int.Parse(tokens[2]);
                        numbers.Insert(position, element);
                        break;
                    
                }
                if (tokens[0] == "end")
                {
                    break;
                }
                
            }

            Console.Write(string.Join(" ", numbers));
        }
    }
}

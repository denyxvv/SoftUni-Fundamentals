using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                switch (tokens[0])
                {
                    case "Add":
                        int number = int.Parse(tokens[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        int element = int.Parse(tokens[1]);
                        int position = int.Parse(tokens[2]);
                        if (position < 0 || position > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        else
                        {
                        numbers.Insert(position, element);
                        }
                        break;
                    case "Remove":
                        int index = int.Parse(tokens[1]);
                        if (index < 0 || index > numbers.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        else
                        {
                            numbers.RemoveAt(index);
                        }
                        break;
                    case "Shift":
                        int count = int.Parse(tokens[2]);
                        if (tokens[1] == "right")
                        {
                            ShiftingRight(count, numbers);
                        }
                        else if (tokens[1] == "left")
                        {
                            ShiftingLeft(count, numbers);
                        }
                        break;


                }

                if (tokens[0] == "End")
                {
                    break;
                }

            }

            Console.Write(string.Join(" ", numbers));
        }

        static void ShiftingLeft(int timesToShiftLeft, List<int> numbers)
        {
            for (int i = 0; i < timesToShiftLeft; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }
        static void ShiftingRight(int timesToShiftRight, List<int> numbers)
        {
            for (int i = 0; i < timesToShiftRight; i++)
            {
                numbers.Insert(0, numbers[numbers.Count - 1]);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }

    }
}

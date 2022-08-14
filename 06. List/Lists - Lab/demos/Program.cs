using System;
using System.Collections.Generic;
using System.Linq;

namespace demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students are in your class: ");
            int numOfStudents = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the names of the students:");

            List<string> students = new List<string>();
            {
                for (int i = 0; i < numOfStudents; i++)
                {
                    string names = Console.ReadLine();
                    students.Add(names);
                }
            }
            Console.WriteLine("--------------------");
            students.Sort();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

        }
    }
}

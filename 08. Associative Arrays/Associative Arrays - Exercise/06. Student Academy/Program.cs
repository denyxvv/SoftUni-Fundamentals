using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();

            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                string studentname = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentname))
                {
                    students[studentname] = new List<double>();
                }
                students[studentname].Add(grade);
            }

            foreach (var student in students)
            {
                string studentName = student.Key;
                double studentAvgGrade = student.Value.Average();
                if (studentAvgGrade >= 4.5)
                {
                    Console.WriteLine($"{studentName} -> {studentAvgGrade:f2}");
                }
            }
        }
    }
}

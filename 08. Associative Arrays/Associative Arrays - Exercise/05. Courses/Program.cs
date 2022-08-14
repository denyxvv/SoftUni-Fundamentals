using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            

            var cmd = Console.ReadLine();

            while (cmd != "end")
            {
                string[] tokens = cmd.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                    
                }
                courses[courseName].Add(studentName);

                cmd = Console.ReadLine();
            }
        PrintCourses(courses);
        }

        static void PrintCourses(Dictionary<string, List<string>> courses)
        {
            foreach (var kvp in courses)
            {
                string courseName = kvp.Key;
                var students = kvp.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}

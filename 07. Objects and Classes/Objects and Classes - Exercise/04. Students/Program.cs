using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 0; i < n; i++)
            {
                string[] currInfo = Console.ReadLine().Split();
                var student = new Students(currInfo[0], currInfo[1], double.Parse(currInfo[2]));
                students.Add(student);
            }
            students = students.OrderByDescending(currStudent => currStudent.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
    class Students
    {
        public Students(string firstname, string lastname, double grade)
        {
            FirstName = firstname;
            LastName = lastname;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}

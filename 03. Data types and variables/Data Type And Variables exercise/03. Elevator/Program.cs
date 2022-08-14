using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeopleInElevator = int.Parse(Console.ReadLine());
            int numberOfMaxPeople = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numberOfPeopleInElevator / numberOfMaxPeople);

            Console.WriteLine(courses);
        }
    }
}

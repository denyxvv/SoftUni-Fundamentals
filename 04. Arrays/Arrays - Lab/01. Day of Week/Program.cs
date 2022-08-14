using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfWeekInput = int.Parse(Console.ReadLine());
            string[] daysOfWeek =
            {
                "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"

            };

            if (daysOfWeekInput >= 1 && daysOfWeekInput <= 7 )
            {
                Console.WriteLine(daysOfWeek[daysOfWeekInput - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}

using System;
using System.Linq;

namespace _01_WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string commands;
            while((commands=Console.ReadLine())!="Travel")
            {
                string[] segments = commands.Split(":");
                string command = segments[0];
                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(segments[1]);
                        string st = segments[2];
                        if(index<=stops.Length-1)
                        {
                           stops = stops.Insert(index, st);
                            Console.WriteLine(stops);
                        }
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(segments[1]);
                        int endIndex = int.Parse(segments[2]);
                        if(startIndex<stops.Length-1 && endIndex<=stops.Length-1)
                        {
                            stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(stops);
                        }
                        break;
                    case "Switch":
                        string oldString = segments[1];
                        string newString = segments[2];
                        if (stops.Contains(oldString))
                        {
                            stops = stops.Replace(oldString, newString);
                            Console.WriteLine(stops);
                        }
                        break;
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}


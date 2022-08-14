using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            Dictionary<string, double> plantsRatings = new Dictionary<string, double>();
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                string[] segments = Console.ReadLine().Split("<->");
                string plant = segments[0];
                int rarity = int.Parse(segments[1]);
                plantsRarity.Add(plant, rarity);
            }
            string commands;
            while((commands = Console.ReadLine())!="Exhibition")
            {
                string[] segments = commands.Split(": ");
                string command = segments[0];
                switch(command)
                {
                    case "Rate":
                        string[] st = segments[1].Split(" - ");
                        string plant = st[0];
                        double rating = double.Parse(st[1]);
                        if(plantsRatings.ContainsKey(plant))
                        {
                            plantsRatings[plant] = rating;
                        }
                        else
                        {
                            plantsRatings.Add(plant, rating);
                        }
                        break;
                    case "Update":
                        string[] st1 = segments[1].Split(" - ");
                        string plant1 = st1[0];
                        int newRarity = int.Parse(st1[1]);
                        if(plantsRarity.ContainsKey(plant1))
                        {
                            plantsRarity[plant1] = newRarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Reset":
                        string plant2 = segments[1];
                        if(plantsRatings.ContainsKey(plant2))
                        {
                            plantsRatings[plant2] = 0.00;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                }
            }
            Console.WriteLine("Plants for the exhibition:");
        }
    }
}


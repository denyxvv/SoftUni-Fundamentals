using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            string output;
            while((output = Console.ReadLine())!= "Sail")
            {
                string[] segments = output.Split("||");
                string cityName = segments[0];
                int population = int.Parse(segments[1]);
                int gold = int.Parse(segments[2]);
                City city = new City(cityName, population, gold);
                bool contains = cities.Any(x => x.CityName == cityName);
                if(contains)
                {
                    foreach(City x in cities)
                    {
                        if(x.CityName == cityName)
                        {
                            x.Population += population;
                            x.Gold += gold;
                        }
                    }
                }
                else
                {
                    cities.Add(city);
                }
            }
            string commands;
            while((commands = Console.ReadLine())!="End")
            {
                string[] segments = commands.Split("=>");
                string command = segments[0];
                string cityName = segments[1];
                switch (command)
                {
                    case "Plunder":
                        int people = int.Parse(segments[2]);
                        int gold = int.Parse(segments[3]);
                        foreach(City x in cities)
                        {
                            if(x.CityName == cityName)
                            {
                                x.Population -= people;
                                x.Gold -= gold;
                                if(x.Population>0 && x.Gold>0)
                                {
                                    Console.WriteLine($"{x.CityName} plundered! {gold} gold stolen, {people} citizens killed.");
                                    
                                }
                                else
                                {
                                    Console.WriteLine($"{x.CityName} plundered! {gold} gold stolen, {people} citizens killed.");
                                    Console.WriteLine($"{x.CityName} has been wiped off the map!");
                                }
                            }
                        }
                        break;
                    case "Prosper":
                        int goldAmount = int.Parse(segments[2]);
                        if(goldAmount<0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            foreach(City x in cities)
                            {
                                if(x.CityName == cityName)
                                {
                                    x.Gold += goldAmount;
                                    Console.WriteLine($"{goldAmount} gold added to the city treasury. {x.CityName} now has {x.Gold} gold.");
                                }
                            }
                        }
                        break;
                }
            }
            int countEmptyCities = 0;
            int countFullCities = 0;
            foreach(City x in cities)
            {
                if(x.Gold<=0||x.Population<=0)
                {
                    countEmptyCities++;
                }
                else if(x.Gold>0&&x.Population>0)
                {
                    countFullCities++;
                }
            }
            if(countEmptyCities==cities.Count)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {countFullCities} wealthy settlements to go to:");
                foreach(City x in cities)
                {
                    if(x.Population>0 && x.Gold>0)
                    {
                        Console.WriteLine(x.ToString());
                    }
                }
            }
        }
    }
    class City
    {
        public string CityName { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
        public City(string cityName, int population, int gold)
        {
            this.CityName = cityName;
            this.Population = population;
            this.Gold = gold;
        }
        public override string ToString()
        {
            return $"{this.CityName} -> Population: {this.Population} citizens, Gold: {this.Gold} kg";
        }
    }
}


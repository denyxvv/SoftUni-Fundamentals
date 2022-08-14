//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _03.WildZoo
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, Animal> animals = new Dictionary<string, Animal>();
//            Dictionary<string, int> areas = new Dictionary<string, int>();

//            while (true)
//            {
//                string[] command = Console.ReadLine().Split(new string[] { ": ", "-" }, StringSplitOptions.RemoveEmptyEntries);

//                if (command[0] == "EndDay")
//                {
//                    break;
//                }

//                if (command[0] == "Add")
//                {
//                    AddAnimal(command, animals, areas);
//                }
//                else if (command[0] == "Feed")
//                {
//                    FeedAnimal(command, animals, areas);
//                }
//            }

//            PrintAnimalsAndAreas(animals, areas);
//        }

//        static void AddAnimal(string[] command, Dictionary<string, Animal> animals, Dictionary<string, int> areas)
//        {
//            string animalName = command[1];
//            int neededFoodQuantity = int.Parse(command[2]);
//            string area = command[3];

//            if (animals.ContainsKey(animalName))
//            {
//                animals[animalName].NeededFood += neededFoodQuantity;
//            }
//            else
//            {
//                animals[animalName] = new Animal(neededFoodQuantity, area);

//                if (!areas.ContainsKey(area))
//                {
//                    areas[area] = 0;
//                }

//                areas[area]++;
//            }
//        }

//        static void FeedAnimal(string[] command, Dictionary<string, Animal> animals, Dictionary<string, int> areas)
//        {
//            string animalName = command[1];
//            int food = int.Parse(command[2]);

//            if (animals.ContainsKey(animalName))
//            {
//                animals[animalName].NeededFood -= food;

//                if (animals[animalName].NeededFood <= 0)
//                {
//                    areas[animals[animalName].Area]--;
//                    animals.Remove(animalName);
//                    Console.WriteLine($"{animalName} was successfully fed");
//                }
//            }
//        }

//        static void PrintAnimalsAndAreas(Dictionary<string, Animal> animals, Dictionary<string, int> areas)
//        {
//            Console.WriteLine("Animals:");

//            foreach (var animal in animals)
//            {
//                Console.WriteLine($" {animal.Key} -> {animal.Value.NeededFood}g");
//            }

//            Console.WriteLine("Areas with hungry animals:");

//            foreach (var area in areas.Where(a => a.Value > 0))
//            {
//                Console.WriteLine($" {area.Key}: {area.Value}");
//            }
//        }
//    }

//    class Animal
//    {
//        public int NeededFood { get; set; }
//        public string Area { get; set; }

//        public Animal(int neededFood, string area)
//        {
//            NeededFood = neededFood;
//            Area = area;
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace FinalExam
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> animalsDictionary = new Dictionary<string, List<string>>();
            Dictionary<string, List<int>> areasAndAnimals = new Dictionary<string, List<int>>();
            string command;
            while ((command = Console.ReadLine()) != "EndDay")
            {
                string[] currCommand = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = currCommand[0];
                string[] secondPartOfCommand = currCommand[1].Split("-", StringSplitOptions.RemoveEmptyEntries);
                string animalName = secondPartOfCommand[0];
                switch (action)
                {
                    case "Add":
                        string neededFoodQuantity = secondPartOfCommand[1];
                        string area = secondPartOfCommand[2];
                        Add(animalName, animalsDictionary, neededFoodQuantity, area);
                        break;
                    case "Feed":
                        string foodToFeed = secondPartOfCommand[1];
                        Feed(animalsDictionary, animalName, foodToFeed);
                        break;
                }
            }
            Console.WriteLine("Animals:");
            foreach (var animal in animalsDictionary)
            {
                Console.WriteLine($" {animal.Key} -> {animal.Value[0]}g");
            }


            Console.WriteLine("Areas with hungry animals:");


            foreach (var animalInDictionary in animalsDictionary)
            {
                //animalName = {animal.Key}
                //animalFOod = animal.Value[0]
                //animalArea = animal.Value[1]
                int animalFood = int.Parse(animalInDictionary.Value[0]);
                if (!areasAndAnimals.ContainsKey(animalInDictionary.Value[1]) && animalFood > 0)
                {
                    areasAndAnimals.Add(animalInDictionary.Value[1], new List<int>());
                    areasAndAnimals[animalInDictionary.Value[1]].Add(1);
                }
                else if (areasAndAnimals.ContainsKey(animalInDictionary.Value[1]) && animalFood > 0)
                {
                    areasAndAnimals[animalInDictionary.Value[1]].Add(1);
                }
            }
            foreach (var areaAndAnimal in areasAndAnimals)
            {
                int count = areaAndAnimal.Value.Count;
                Console.WriteLine($"{areaAndAnimal.Key}: {count}");
            }

        }

        static void Add(string animalName, Dictionary<string, List<string>> animalsDictionary, string neededFoodQuantity, string area)
        {
            if (!animalsDictionary.ContainsKey(animalName))
            {
                animalsDictionary.Add(animalName, new List<string>());
                animalsDictionary[animalName].Add(neededFoodQuantity);
                animalsDictionary[animalName].Add(area);
            }
            else
            {
                int currFood = int.Parse(animalsDictionary[animalName][0]);
                int addedFood = int.Parse(neededFoodQuantity);
                string result = (currFood + addedFood).ToString();
                animalsDictionary[animalName][0] = result;
            }
        }
        static void Feed(Dictionary<string, List<string>> animalsDictionary, string animalName, string foodToFeed)
        {
            if (animalsDictionary.ContainsKey(animalName))
            {
                int currFood = int.Parse(animalsDictionary[animalName][0]);
                int addedFood = int.Parse(foodToFeed);
                int resultAsInt = currFood - addedFood;
                if (resultAsInt <= 0)
                {
                    animalsDictionary.Remove(animalName);
                    Console.WriteLine($"{animalName} was successfully fed");
                }
                else
                {
                    animalsDictionary[animalName][0] = resultAsInt.ToString();
                }


            }
        }
    }
}
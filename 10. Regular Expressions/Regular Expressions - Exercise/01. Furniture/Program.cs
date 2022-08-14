using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furniture>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

            string furniture = Console.ReadLine();

            List<string> furnitureNames = new List<string>();

            double sum = 0;

            while (furniture != "Purchase")
            {
                Match matchedFurnitures = Regex.Match(furniture, pattern, RegexOptions.IgnoreCase);

                if (matchedFurnitures.Success)
                {
                    var furnitureName = matchedFurnitures.Groups["furniture"].Value;
                    var furniturePrice = double.Parse(matchedFurnitures.Groups["price"].Value);
                    var furnitureQuantity = int.Parse(matchedFurnitures.Groups["quantity"].Value);
                    furnitureNames.Add(furnitureName);
                    sum += furniturePrice * furnitureQuantity;
                }
                furniture = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (var furnitureName in furnitureNames)
            {
                Console.WriteLine(furnitureName);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
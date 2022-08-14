using System;

namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double price1PackageFlour = double.Parse(Console.ReadLine());
            double price1Egg = double.Parse(Console.ReadLine());
            double price1Apron = double.Parse(Console.ReadLine());
            double freePackages = 0;

            if (students % 5 == 0)
            {
                freePackages = students / 5;
            }

            double priceAllAprons = price1Apron * (students + Math.Ceiling(students * 0.2));
            double priceAllEggs = (price1Egg * 10) * students; 
            double priceAllFlour = price1PackageFlour * (students - freePackages); 
            double itemsForStudents = priceAllAprons + priceAllEggs + priceAllFlour;
            
            if (itemsForStudents <= budget)
            {
                Console.WriteLine($"Items purchased for {itemsForStudents:f2}$.");
            }
            if (itemsForStudents > budget)
            {
                double neededMoney = itemsForStudents - budget;
                Console.WriteLine($"{neededMoney:f2}$ more needed.");
            }
            
            
            
        }
    }
}

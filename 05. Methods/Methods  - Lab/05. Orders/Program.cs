using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            //•	coffee – 1.50
            //•	water – 1.00
            //•	coke – 1.40
            //•	snacks – 2.00
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                default:
                    break;
            }
            Calculation(price , quantity);
        }

        static void Calculation(double price, int quantity)
        {
            Console.WriteLine($"{price * quantity:f2}");
        }
    }
}

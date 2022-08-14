using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = new Dictionary<string, double>();
            var newOrders = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "buy")
            {
                var cmd = input.Split();
                string productName = cmd[0];
                double price = double.Parse(cmd[1]);
                int quantity = int.Parse(cmd[2]);


                if (!orders.ContainsKey(productName))
                {
                    orders.Add(productName, price);
                    newOrders.Add(productName, quantity);
                }
                else if (orders.ContainsKey(productName))
               {
                   orders.Remove(productName);
                   orders.Add(productName, price);
                    newOrders[productName] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                       Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");

                    }
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> customers = new List<string>();
            List<string> productNames = new List<string>();
            List<double> prices = new List<double>();
            

            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";

            string orders = Console.ReadLine();
            double income = 0;

            while (orders != "end of shift")
            {
                Match matchedOrders = Regex.Match(orders, pattern);

                if (matchedOrders.Success)
                {
                    var customer = matchedOrders.Groups["customer"].Value;
                    var product = matchedOrders.Groups["product"].Value;
                    var productCount = int.Parse(matchedOrders.Groups["count"].Value);
                    var productPrice = double.Parse(matchedOrders.Groups["price"].Value);
                    income += productPrice * productCount;

                    double calc = productPrice * productCount;
                    Console.WriteLine($"{customer}: {product} - {calc:f2}");
                }
                orders = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {income:f2}");
                
        }
    }
}

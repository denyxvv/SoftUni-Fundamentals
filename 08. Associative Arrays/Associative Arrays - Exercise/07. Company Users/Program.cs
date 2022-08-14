using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                string[] tokens = cmd.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string companyName = tokens[0];
                string employeeId = tokens[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }


                if (companies[companyName].Contains(employeeId))
                {
                    cmd = Console.ReadLine();
                    continue;
                }

                companies[companyName].Add(employeeId);

                cmd = Console.ReadLine();
            }

            foreach (var company in companies)
            {

                Console.WriteLine($"{company.Key}");

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }


    }
}

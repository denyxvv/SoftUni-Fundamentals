using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();

            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                var command = Console.ReadLine().Split();
                var actions = command[0];
                var username = command[1];

                switch (actions)
                {
                    case "register":
                        var plateNumber = command[2];
                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, plateNumber);
                            Console.WriteLine($"{username} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        if (!users.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            users.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;

                }
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }

        }
    }
}

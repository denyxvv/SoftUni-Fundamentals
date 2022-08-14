using System;
using System.Linq;

namespace _01_ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string commands;
            while((commands=Console.ReadLine())!="Generate")
            {
                string[] segments = commands.Split(">>>");
                string command = segments[0];
                switch (command)
                {
                    case "Contains":
                        string substring = segments[1];
                        if(activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string com = segments[1];
                        int startIndex = int.Parse(segments[2]);
                        int endIndex = int.Parse(segments[3]);
                        if (com == "Upper")
                        {
                            string substring1 = activationKey.Substring(startIndex, endIndex - startIndex);
                            activationKey = activationKey.Remove(startIndex, substring1.Length);
                            substring1 = substring1.ToUpper();
                            activationKey = activationKey.Insert(startIndex, substring1);
                            Console.WriteLine(activationKey);
                        }
                        else
                        {
                            string substring1 = activationKey.Substring(startIndex, endIndex - startIndex);
                            activationKey = activationKey.Remove(startIndex, substring1.Length);
                            substring1 = substring1.ToLower();
                            activationKey = activationKey.Insert(startIndex, substring1);
                            Console.WriteLine(activationKey);
                        }
                            break;
                    case "Slice":
                        int start = int.Parse(segments[1]);
                        int end = int.Parse(segments[2]);
                        activationKey = activationKey.Remove(start, end-start);
                        Console.WriteLine(activationKey);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}


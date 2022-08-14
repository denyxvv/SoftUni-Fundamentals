using System;
using System.Linq;

namespace _01_SecretChat2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string commands;
            while((commands=Console.ReadLine())!="Reveal")
            {
                string[] segmnets = commands.Split(":|:");
                string command = segmnets[0];
                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(segmnets[1]);
                        message = message.Insert(index, " ");
                        Console.WriteLine(message);
                        break;
                    case "Reverse":
                        string substring = segmnets[1];
                        if(message.Contains(substring))
                        {
                            int ind = message.IndexOf(substring);
                            message = message.Remove(ind, substring.Length);
                            message += String.Join("", substring.Reverse());
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        string substring1 = segmnets[1];
                        string replacement = segmnets[2];
                        message = message.Replace(substring1, replacement);
                        Console.WriteLine(message);
                        break;
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}


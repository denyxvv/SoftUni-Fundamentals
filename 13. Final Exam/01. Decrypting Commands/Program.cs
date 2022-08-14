using System;
using System.Diagnostics.CodeAnalysis;

namespace _01._Decrypting_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string commands = Console.ReadLine();
            while (commands != "Finish")
            {
                string[] tokens = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string first = tokens[0];
                switch (first)
                {
                    case "Replace":
                        text = Replace(tokens[1], tokens[2], text);
                        break;
                    case "Cut":
                        text = Cut(int.Parse(tokens[1]), int.Parse(tokens[2]), text);
                        break;
                    case "Make":
                        text = Make(tokens[1], text);
                        break;
                    case "Check":
                        text = Check(tokens[1], text);
                        break;
                    case "Sum":
                        text = Sum(int.Parse(tokens[1]), int.Parse(tokens[2]), text);
                        break;
                }

                commands = Console.ReadLine();
            }
        }

        static string Sum(int startIndex, int endIndex, string text)
        {
            int sum = 0;
            if (startIndex >= 0 && endIndex <= text.Length - 1)
            {
                string stringy = text.Substring(startIndex, endIndex);
                if (startIndex >= 0 && endIndex <= stringy.Length)
                {

                    for (int i = 0; i < stringy.Length; i++)
                    {
                        sum += stringy[i];
                    }

                    Console.WriteLine(sum);
                }
            }
            else
            {
                Console.WriteLine("Invalid indices!");
            }

            return text;
        }

        static string Cut(int startIndex, int endIndex, string text)
        {
            if (startIndex >= 0 && endIndex < text.Length )
            {
                text = text.Remove(startIndex, endIndex - startIndex);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Invalid indices!");
            }

            return text;
        }

        static string Replace(string currentChar, string newChar, string text)
        {
            text = text.Replace(currentChar, newChar);
            Console.WriteLine(text);
            return text;
        }

        static string Check(string stringy, string text)
        {
            if (text.Contains(stringy))
            {
                Console.WriteLine($"Message contains {stringy}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {stringy}");
            }
            return text;
        }

        static string Make(string casing, string text)
        {
            if (casing == "Upper")
            {
                text = text.ToUpper();
                Console.WriteLine(text);
            }
            else
            {
                text = text.ToLower();
                Console.WriteLine(text);
            }
            return text;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validUsernames = new List<string>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in input)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    bool isValid = true;

                    for (int i = 0; i < name.Length; i++)
                    {
                        char currentChar = name[i];

                        if (!(currentChar == '-' || currentChar == '_' || char.IsLetterOrDigit(currentChar)))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        validUsernames.Add(name);
                    }
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, validUsernames));

        }
    }
}
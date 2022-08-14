using System;
using System.Collections.Generic;

namespace _01_TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            List<char> message = new List<char>();
            message.AddRange(encryptedMessage);
            string input;
            while ((input=Console.ReadLine())!="Decode")
            {
                string[] segments = input.Split("|");
                string command = segments[0];
                if(command=="Move")
                {
                    int numberLetters = int.Parse(segments[1]);
                    for(int i=0; i<numberLetters;i++)
                    {
                        char pom = message[i];
                        message.RemoveAt(i);
                        message.Add(pom);
                        numberLetters--;
                        i = -1;
                    }
                }
                else if(command=="Insert")
                {
                    int index = int.Parse(segments[1]);
                    string value = segments[2];
                    string firstPart = string.Empty, secondPart = string.Empty;
                    for(int i=0; i<index;i++)
                    {
                        firstPart += message[i];
                    }
                    for(int i=index; i<message.Count;i++)
                    {
                        secondPart += message[i];
                    }
                    message.Clear();
                    message.AddRange(firstPart+value+secondPart);
                }
                else
                {
                    char substring = char.Parse(segments[1]);
                    char replacment = char.Parse(segments[2]);
                    for(int i=0; i<message.Count;i++)
                    {
                        if (message[i]==substring)
                        {
                            message[i] = replacment;
                        }
                    }
                }
            }
            Console.WriteLine($"The decrypted message is: {String.Join("", message)}");
        }
    }
}


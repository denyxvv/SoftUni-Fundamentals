using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Chat_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();
                string action = tokens[0];
                switch (action)
                {
                    case "Chat":
                        string message = tokens[1];
                        chat.Add(message);
                        break;
                    case "Delete":
                        string messageToDelete = tokens[1];
                        if (chat.Contains(messageToDelete))
                        {
                        chat.Remove(messageToDelete);
                        }
                        break;
                    case "Edit":
                        string messageFromChat = tokens[1];
                        string editedMessage = tokens[2];
                       int index1 = chat.IndexOf(messageFromChat);
                        chat.Add(editedMessage);
                        int index2 = chat.IndexOf(editedMessage);
                        if (chat.Contains(messageFromChat))
                        { 
                            Swap(index1, index2, chat);
                            chat.RemoveAt(index2);
                        }
                        break;
                    case "Pin":
                        string messagePin = tokens[1];
                        if (chat.Contains(messagePin))
                        {
                            chat.Remove(messagePin);
                            chat.Add(messagePin);
                        }
                        break;
                    case "Spam":
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            string msg1 = tokens[i];
                            chat.Add(msg1);
                        }
                        break;

                }
            }
            foreach (var msg in chat)
            {
                Console.WriteLine(msg);
            }
        }
        static void Swap(int firstIndex, int secondIndex, List<string> numbers)
        {
            string temp = numbers[firstIndex]; ;
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;

        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

namespace _02._Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"^(\${1}|\%{1})(?<name>[A-Z][a-z]{2,})\1: \[(?<firstNum>\d+)\]\|\[(?<secondNum>\d+)\]\|\[(?<thirdNum>\d+)\]\|$";
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string messages = Console.ReadLine();
                if (Regex.IsMatch(messages, pattern))
                {
                    Match matchedMessages = Regex.Match(messages, pattern);
                    string tag = matchedMessages.Groups["name"].Value;
                    int firstNum = int.Parse(matchedMessages.Groups["firstNum"].Value);
                    int secondNum = int.Parse(matchedMessages.Groups["secondNum"].Value);
                    int thirdNum = int.Parse(matchedMessages.Groups["thirdNum"].Value);

                    string decryptedMessage = string.Join("", (char)firstNum) + string.Join("", (char)secondNum) + string.Join("", (char)thirdNum);
                    Console.WriteLine($"{tag}: {decryptedMessage}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
            
        }
    }
}

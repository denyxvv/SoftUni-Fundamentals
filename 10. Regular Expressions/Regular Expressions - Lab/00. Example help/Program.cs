using System;
using System.Text.RegularExpressions;

namespace _00._Example_help
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Bryan Taylor";
            string pattern = @"([A-Z][a-z]{1,}) ([A-Z][a-z]{2,})";

            Regex regex = new Regex(pattern);
            Match match = regex.Match(text);

            Console.WriteLine(match.Groups.Count); // 2
            Console.WriteLine($"Matched texts: {match.Groups[0]}"); // all the matched names
            Console.WriteLine($"First name: {match.Groups[1]}"); // first name
            Console.WriteLine($"Last name: {match.Groups[2]}"); // last name
        }
    }
}

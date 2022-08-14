using System;
using System.Text.RegularExpressions;
namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})";

            Regex regex = new Regex(pattern);
            MatchCollection matchedNames = regex.Matches(text);

            foreach (Match name in matchedNames)
            {
                Console.Write(name+ " ");

            }

        }
    }
}

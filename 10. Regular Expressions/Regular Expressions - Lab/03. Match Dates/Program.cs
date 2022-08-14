using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string dates = Console.ReadLine();

            string pattern = @"(?<day>[\d]{2})([\.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>[\d]{4})";

            Regex regex = new Regex(pattern);
            MatchCollection matchedDates = regex.Matches(dates);


            foreach (Match matchedDate in matchedDates)
            {
                var day = matchedDate.Groups["day"].Value;
                var month = matchedDate.Groups["month"].Value;
                var year = matchedDate.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
                
            }

            
        }
    }
}

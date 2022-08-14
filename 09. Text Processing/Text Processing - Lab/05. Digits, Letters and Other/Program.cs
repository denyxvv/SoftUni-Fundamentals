using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomString = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            foreach (var ch in randomString)
            {
                if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else
                {
                    others.Append(ch);
                }
            }



            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);



        }
    }
}

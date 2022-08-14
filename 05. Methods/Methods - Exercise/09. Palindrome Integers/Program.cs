using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool IsIntegerPalindrome = IsNumberPalindrome(input);
                Console.WriteLine(IsIntegerPalindrome.ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool IsNumberPalindrome(string input)
        {
            int number = int.Parse(input);
            if (number >= 0 && number <= 9)
            {
                return true;
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input [i] == input[input.Length - 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}

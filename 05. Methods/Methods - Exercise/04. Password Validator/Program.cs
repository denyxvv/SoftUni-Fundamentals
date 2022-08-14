using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isCharsValid = LimitedChars(password);
            bool isPassNumsAndLetters = ValidPassText(password);
            bool doesPassHave2Digits = PassWith2digits(password);
            if (!isCharsValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPassNumsAndLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!doesPassHave2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isCharsValid && isPassNumsAndLetters && doesPassHave2Digits)
            {
                Console.WriteLine("Password is valid");
            }
            
        }

        private static bool PassWith2digits(string password)
        {
                int digitCounter = 0;

            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    digitCounter++;
                }
                
            }
            if (digitCounter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private  static bool ValidPassText(string pass1)
        {
            foreach (var symbol in pass1)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool LimitedChars(string pass)
        {
            if (pass.Length >= 6 && pass.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}

using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Console.ReadLine().Split();
            string str1 = arguments[0];
            string str2 = arguments[1];

            CharacterMultiplier(str1, str2);
        }

        public static void CharacterMultiplier(string str1, string str2)
        {
            int sum = 0;

            string longest = "";
            string shortest = "";

            if (str1.Length > str2.Length)
            {
                longest = str1;
                shortest = str2;
            }
            else
            {
                longest = str2;
                shortest = str1;
            }
            for (int i = 0; i < shortest.Length; i++)
            {
                sum += str1[i] * str2[i];
            }

            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }


            Console.WriteLine(sum);

        }
    }
}

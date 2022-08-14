using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var PlayerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            var PlayerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (PlayerOne.Count > 0 && PlayerTwo.Count > 0)
            {
                
                    if (PlayerOne[0] > PlayerTwo[0])
                    {
                        PlayerOne.Add(PlayerOne[0]);
                        PlayerOne.Add(PlayerTwo[0]);
                    }
                    else if (PlayerTwo[0] > PlayerOne[0])
                    {
                        PlayerTwo.Add(PlayerTwo[0]);
                        PlayerTwo.Add(PlayerOne[0]);
                    }
                    
                PlayerOne.Remove(PlayerOne[0]);
                PlayerTwo.Remove(PlayerTwo[0]);

            }
            if (PlayerOne.Sum() > PlayerTwo.Sum())
            {
                int sum = PlayerOne.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = PlayerTwo.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}

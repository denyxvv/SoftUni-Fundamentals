using System;
using System.Numerics;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder sb = new StringBuilder();
            int remainder = 0;

            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                char lastNum = bigNum[i];
                int lastNumAsDigit = int.Parse(lastNum.ToString());

                int result = lastNumAsDigit * num + remainder;

                sb.Append(result % 10);

                remainder = result / 10;
            }
            if (remainder != 0)
            {
            sb.Append(remainder);

            }

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                Console.Write(sb[i]);
            }

            
            
        }
    }
}

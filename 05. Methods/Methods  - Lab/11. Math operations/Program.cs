using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());

            switch (@operator)
            {
                case "/":
                    Console.WriteLine(Dividing(n1, n2));
                    break;
                case "*":
                    Console.WriteLine(Multiplying(n1, n2));
                    break;
                case "+":
                    Console.WriteLine(Combining(n1, n2));
                    break;
                case "-":
                    Console.WriteLine(Subtracting(n1, n2));
                    break;
                default:
                    break;
            }
        }
        static double Dividing(int n1, int n2)
        {
            return n1 / n2;
        }
        static double Multiplying(int n1, int n2)
        {
            return n1 * n2;
        }
        static double Combining(int n1, int n2)
        {
            return n1 + n2;
        }
        static double Subtracting(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}

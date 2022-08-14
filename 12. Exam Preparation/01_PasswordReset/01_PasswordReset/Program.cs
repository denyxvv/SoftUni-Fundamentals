using System;
using System.Linq;

namespace _01_PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string commands;
            while((commands=Console.ReadLine())!="Done")
            {
                string[] segments = commands.Split();
                string command = segments[0];
                switch (command)
                {
                    case "TakeOdd":
                        string rawPass = string.Empty;
                        for(int i=1; i<password.Length;i+=2)
                        {
                            rawPass += password[i];
                        }
                        password = rawPass;
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        int index = int.Parse(segments[1]);
                        int lenght = int.Parse(segments[2]);
                        password = password.Remove(index, lenght);
                        Console.WriteLine(password);
                        break;
                    case "Substitute":
                        string substring = segments[1];
                        string substitute = segments[2];
                        if(password.Contains(substring))
                        {
                            password = password.Replace(substring, substitute);
                            Console.WriteLine(password);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}

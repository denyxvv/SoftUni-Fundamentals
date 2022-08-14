using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();

            while (cmd != "end")
            {
                string reversed = "";

                for (int i = cmd.Length - 1; i >= 0; i--)
                {
                    reversed += cmd[i];
                }
                Console.WriteLine($"{cmd} = {reversed}");

                cmd = Console.ReadLine();
            }

            

        }
    }
}

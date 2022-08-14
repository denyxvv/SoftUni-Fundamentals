using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLocation = Console.ReadLine().Split("\\");

            int lastIndex = fileLocation.Length - 1;

            string[] fileNameArr = fileLocation[lastIndex].Split(".");
            string fileName = fileNameArr[0];
            string[] fileExtensionArr = fileLocation[lastIndex].Split(".");
            string fileExtension = fileExtensionArr[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}

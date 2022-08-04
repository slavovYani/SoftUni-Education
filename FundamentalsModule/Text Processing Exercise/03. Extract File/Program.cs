using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileLocation = Console.ReadLine().Split('\\');

            string fullFileName = fileLocation[fileLocation.Length - 1];
            string[] fileNameAndExtension = fullFileName.Split('.');
            string fileName = fileNameAndExtension[0];
            string extension = fileNameAndExtension[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}

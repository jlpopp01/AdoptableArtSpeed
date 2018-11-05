using System;
using System.IO;

namespace AdoptableArtSpeed
{
    class Program
    {

        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            string fileName = Path.Combine(directory.Title, "AdoptableArt.csv");
            var fileContents = ReadFile(fileName);
            Console.WriteLine(fileContents);

        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }
    }
}

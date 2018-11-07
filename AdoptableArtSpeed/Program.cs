using System;
using System.IO;

namespace AdoptableArtSpeed
{
    class Program
    {
        private static string line;

        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("AdoptableArt.csv"))
                {
                    while ((line = sr.ReadLine()) != null)
                        {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("I lost your data!");
                Console.WriteLine(e.Message);
            }
        }

    }
}

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
                Console.WriteLine("Someone stole all the art!");
                Console.WriteLine(e.Message);
            }
        }

    }
}



// Import data from CSV
// Parse data
// Prompt user for what art they are looking for
// present adoptable or nonadoptable art
// bonus : search by cost


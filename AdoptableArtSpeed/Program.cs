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

            Console.ReadLine();
        }

      

    }
}



// Import data from CSV
// Parse data
// Welcome person to app, ask their name
// ask how much they would like to spend on adoptable art
// all art in CSV is adoptable, set parameters for cost
// 


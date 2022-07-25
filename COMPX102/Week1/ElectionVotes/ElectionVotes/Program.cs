using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ElectionVotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a file name: ");
            string filename = Console.ReadLine();

            Console.WriteLine(filename);

            try
            {
                StreamReader reader = new StreamReader(@filename);

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] words = line.Split(',');

                    Console.WriteLine(words[1]);
                }
                reader.Close();
            }
            catch
            {
                Console.WriteLine("Error opening and reading file, try again");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

    }
}

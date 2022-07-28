using System;
using System.IO;
using System.Text;

namespace Ex3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Variables
            StreamReader reader;
            string fileName = "names.txt";

            List<string> names = new List<string>();
            List<string> uNames = new List<string>();

            string Line;

            //Opening file
            reader = File.OpenText(fileName);

            //Loop until end of file
            while (!reader.EndOfStream)
            {
                Line = reader.ReadLine();

                if (!uNames.Contains(Line))
                {
                    uNames.Add(Line);
                    names.Add(Line);
                }
                else
                {
                    names.Add(Line);
                }
            }

            //grouping names
            var grp = names.GroupBy(i => i);

            //Counting and displaying eaach group
            foreach(var gr in grp)
            {
                Console.WriteLine($"{gr.Key}\t{gr.Count()}");
            }

            //enter to quit
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
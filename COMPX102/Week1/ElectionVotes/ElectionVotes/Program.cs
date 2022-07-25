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
            //User input for filename
            Console.Write("Enter a file name: ");
            string filename = Console.ReadLine();

            Console.WriteLine();

            try
            {
                StreamReader reader = new StreamReader(@filename);

                int votesCount = 0;

                //Lists for keeping each line of file
                List<int> votes = new List<int>();
                List<string> parties = new List<string>();

                //Loop to read file
                while (!reader.EndOfStream)
                {
                    //Reading each line into array
                    string line = reader.ReadLine();
                    string[] words = line.Split(',');

                    votesCount += int.Parse(words[1]);

                    //Adding items into lists for later use
                    votes.Add(int.Parse(words[1]));
                    parties.Add(words[0]);

                    //Displaying each line neatly
                    Console.WriteLine($"Party: {words[0]}\nVotes: {words[1]}\n");
                }
                reader.Close();
                //Displaying total number of votes
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Total number of votes is... " + votesCount);
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
                
                //Calculating number of votes needed for seat
                int num = votesCount / 120;

                //Using loop to display how many seats each party has
                for(int i = 0; i < votes.Count; i++)
                {
                    Console.WriteLine($"{parties[i]} has... {votes[i] / num} seats\n");
                }
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

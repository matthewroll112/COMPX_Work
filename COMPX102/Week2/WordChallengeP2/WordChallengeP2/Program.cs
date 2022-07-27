using System;
using System.IO;
using System.Text;

namespace WordChallengeP2
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
            StreamReader streamReader;

            char[] charArr;
            int value = 0;

            string file1 = "sowpods.txt";
            List<string> words1 = new List<string>();

            string file2 = "TWL06.txt";
            List<string> words2 = new List<string>();

            List<string> words3 = new List<string>();

            //Opening first file
            streamReader = File.OpenText(file1);

            //Loop to read through and save to list
            while (!streamReader.EndOfStream)
            {
                words1.Add(streamReader.ReadLine().ToUpper());
            }
            streamReader.Close();

            //For loop for values of words
            for(int i = 0; i < words1.Count; i++)
            {
                value = 0;
                charArr = words1[i].ToCharArray();
                for(int f = 0; f < charArr.Length; f++)
                {
                    //For loop to search through alphabet using ascii
                    for (int j = 65; j < 65 + 26; j++)
                    {
                        if (charArr[f] == Convert.ToChar(j))
                        {
                            value += j - 64;
                        }
                    }
                }
                if (value >= 90 && value <= 110)
                {
                    if(value == 100)
                    {
                        words3.Add(words1[i]);
                    }
                    Console.WriteLine("Word: " + words1[i] + " Value = " + value);
                }
            }

            //Exact same thing for file2
            streamReader = File.OpenText(file2);

            while (!streamReader.EndOfStream)
            {
                words2.Add(streamReader.ReadLine());
            }
            streamReader.Close();

            //For loop for values of words
            for (int i = 0; i < words2.Count; i++)
            {
                value = 0;
                charArr = words2[i].ToCharArray();
                for (int f = 0; f < charArr.Length; f++)
                {
                    //For loop to search through alphabet using ascii
                    for (int j = 65; j < 65 + 26; j++)
                    {
                        if (charArr[f] == Convert.ToChar(j))
                        {
                            value += j - 64;
                        }
                    }
                }
                if (value >= 90 && value <= 110)
                {
                    if(value == 100)
                    {
                        words3.Add(words2[i]);
                    }
                    Console.WriteLine("Word: " + words2[i] + " Value = " + value);
                }
            }

            //Output for words that equal 100
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Words that equal 100");
            foreach(string word in words3)
            {
                Console.WriteLine(word);
            }

            //So app doesn't close
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int value = 0;

            //user input
            Console.Write("Enter a word: ");
            string word = Console.ReadLine().ToUpper();
            char[] chars = word.ToCharArray();

            //loop to loop through all of alphabet
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 65; j < 65 + 26; j++)
                {
                    if (chars[i] == Convert.ToChar(j))
                    {
                        value += j - 64;
                    }
                }
            }

            Console.WriteLine("Your word is " + word + "\nThe value is: " + value);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press enter to end...");
            Console.ReadLine();
        }
    }
}

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
            //variable for value of word
            int num = 0;
            int count = 0;
            //User input
            Console.Write("Enter a word: ");
            string word = Console.ReadLine().ToUpper();
            var charArr = word.ToCharArray();
           
            //For loop to display chars using ascii values
            for(int i = 65; i < 65+26; i++)
            {
                //Console.WriteLine(Convert.ToChar(i) + " = $" + Convert.ToString(i - 64));
                if(Convert.ToChar(i) == )
                {
                    num = num + (i - 64);
                    count++;
                }
            }

            Console.WriteLine("Your word equals $" + num);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press enter to end...");
            Console.ReadLine();
        }
    }
}

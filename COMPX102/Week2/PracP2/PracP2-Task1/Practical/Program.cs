using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numChars = 5;
            //string c = "*";


            //DrawChars(numChars, c);
            try
            {
                //user input
                Console.Write("Enter a number of characters: ");
                int numChars = int.Parse(Console.ReadLine());
                Console.Write("Enter a character: ");
                string c = Console.ReadLine();

                //Use DrawChars method
                DrawChars(numChars, c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            


            // Wait for user to have read the output
            Console.WriteLine();
            Console.Write("<Press enter to finish>");
            Console.ReadLine();
        }

        /// <summary>
        /// Draws a line of characters
        /// </summary>
        /// <param name="n">Number of characters to draw</param>
        /// <param name="s">Character to draw n times</param>
        static void DrawChars(int n, string s)
        {
            int count;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        if (j >= 9)
                        {
                            count = j;
                            Console.Write(count - 9);
                        }
                        else
                        {
                            Console.Write(j + 1);
                        }
                    }
                    else
                    {
                        Console.Write(s);
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

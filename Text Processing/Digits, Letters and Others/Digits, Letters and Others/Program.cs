using System;
using System.Collections.Generic;

namespace Digits__Letters_and_Others
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<char> digits = new List<char>(); // List to store digit characters
            List<char> letters = new List<char>(); // List to store letter characters
            List<char> others = new List<char>(); // List to store other characters

            foreach (char c in str) // Iterate through each character in the input string
            {
                if (char.IsDigit(c))
                {
                    digits.Add(c);
                }
                else if (char.IsLetter(c))
                {
                    letters.Add(c);
                }
                else
                {
                    others.Add(c);
                }
            }

            foreach (char d in digits)
            {
                Console.Write(d); // Print digits without newline
            }

            Console.WriteLine();
            foreach (char l in letters)
            {
                Console.Write(l); // Print letters without newline
            }

            Console.WriteLine();
            foreach (char o in others)
            {
                Console.Write(o); // Print others without newline
            }
        }
    }
}

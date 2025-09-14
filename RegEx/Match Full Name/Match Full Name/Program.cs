using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b"); // Pattern to match full names
            var names = Console.ReadLine()!;

            var matchedNames = regex.Matches(names); // Find all matches in the input string

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " "); // Print each matched full name followed by a space
            }

            Console.WriteLine();
        }
    }
}

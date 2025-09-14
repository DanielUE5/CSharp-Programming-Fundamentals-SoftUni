using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var regex = new Regex("(?<!\\S)\\+359([ -])2\\1\\d{3}\\1\\d{4}\\b"); // Pattern to match phone numbers in the format +359 2 222 2222 or +359-2-222-2222

            var phones = Console.ReadLine();

            var phoneMatches = regex.Matches(phones); // Find all matches in the input string

            var matchedPhones = phoneMatches 
                .Cast<Match>() // Cast the collection to Match objects
                .Select(method => method.Value.Trim()) // Extract the matched phone numbers
                .ToArray(); 

            Console.WriteLine(string.Join(", ", matchedPhones)); // Print the matched phone numbers separated by commas
        }
    }
}

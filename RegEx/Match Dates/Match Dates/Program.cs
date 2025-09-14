using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine()!;

            var regex = new Regex(@"\b(?<day>\d{2})(?<sep>[.\-\/])(?<month>[A-Z][a-z]{2})\k<sep>(?<year>\d{4})\b"); // Pattern to match dates in the format "dd{sep}MMM{sep}yyyy"

            foreach (Match m in regex.Matches(input)) // Find all matches in the input string
            {
                string day = m.Groups["day"].Value;
                string month = m.Groups["month"].Value;
                string year = m.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}"); // Output the extracted day, month, and year
            }
        }
    }
}

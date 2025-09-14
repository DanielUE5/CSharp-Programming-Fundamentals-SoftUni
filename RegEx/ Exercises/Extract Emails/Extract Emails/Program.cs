using System.Text.RegularExpressions;

namespace Extract_Emails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? text = Console.ReadLine();

            string pattern = @"(?<=\s|^)([A-Za-z0-9]+[A-Za-z0-9._-]*[A-Za-z0-9]+)@([A-Za-z]+(?:-[A-Za-z]+)*(\.[A-Za-z]+(?:-[A-Za-z]+)*)+)\b"; // Improved regex pattern to match valid email addresses

            var matches = Regex.Matches(text ?? string.Empty, pattern);

            foreach (Match m in matches)
                Console.WriteLine(m.Value);
        }
    }
}

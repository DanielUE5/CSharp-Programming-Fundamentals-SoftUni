using System.Text.RegularExpressions;

namespace Furniture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pattern = @">>([A-Za-z\s]+)<<(\d+(?:\.\d+)?)!(\d+)";
            List<string> furniture = new List<string>(); // List to store furniture names
            double total = 0;

            string input;
            while ((input = Console.ReadLine()!) != "Purchase") // Read input until "Purchase"
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success) // If the input matches the pattern
                {
                    string name = match.Groups[1].Value; // Extract furniture name
                    double price = double.Parse(match.Groups[2].Value); // Extract price
                    int quantity = int.Parse(match.Groups[3].Value); // Extract quantity

                    furniture.Add(name);
                    total += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:"); // Print the list of furniture
            foreach (string item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {total:F2}"); // Print the total money spent formatted to 2 decimal places
        }
    }
}

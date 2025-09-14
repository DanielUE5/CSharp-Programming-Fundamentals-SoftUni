using System.Globalization;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var rx = new Regex(
            @"%(?<name>[A-Z][a-z]+)%[^\|\$\%\.]*<(?<product>\w+)>[^\|\$\%\.]*\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(?:\.\d+)?)\$",
            RegexOptions.Compiled); // Compiled option for better performance on repeated use

            decimal totalIncome = 0m;
            string line;

            while ((line = Console.ReadLine()!) != "end of shift") // Using null-forgiving operator to indicate we expect non-null input
            {
                var m = rx.Match(line);
                if (!m.Success) continue;

                string name = m.Groups["name"].Value;
                string product = m.Groups["product"].Value;
                int count = int.Parse(m.Groups["count"].Value);
                decimal price = decimal.Parse(m.Groups["price"].Value, CultureInfo.InvariantCulture); // Parsing with InvariantCulture to handle decimal point correctly

                decimal total = count * price;
                Console.WriteLine($"{name}: {product} - {total.ToString("F2", CultureInfo.InvariantCulture)}"); // Formatting with InvariantCulture to ensure consistent decimal point representation
                totalIncome += total;
            }

            Console.WriteLine($"Total income: {totalIncome.ToString("F2", CultureInfo.InvariantCulture)}"); // Formatting with InvariantCulture to ensure consistent decimal point representation
        }
    }
}

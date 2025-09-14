using System.Globalization;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine(); 
            if (input == null) 
                return;
            var demons = input.Split(',', StringSplitOptions.RemoveEmptyEntries) 
                              .Select(s => s.Trim())
                              .Where(s => s.Length > 0)
                              .ToList();

            var numberRx = new Regex(@"[+\-]?\d+(?:\.\d+)?");

            var results = new List<(string name, int health, double damage)>();

            foreach (var name in demons)
            {
                int health = 0;
                foreach (char c in name)
                    if (!char.IsDigit(c) && c != '+' && c != '-' && c != '*' && c != '/' && c != '.')
                        health += c;

                double damage = 0.0;
                foreach (Match m in numberRx.Matches(name))
                    damage += double.Parse(m.Value, CultureInfo.InvariantCulture);

                foreach (char c in name)
                {
                    if (c == '*') damage *= 2;
                    else if (c == '/') damage /= 2;
                }

                results.Add((name, health, damage));
            }

            foreach (var r in results.OrderBy(r => r.name, StringComparer.Ordinal))
                Console.WriteLine($"{r.name} - {r.health} health, {r.damage:F2} damage");
        }
    }
}

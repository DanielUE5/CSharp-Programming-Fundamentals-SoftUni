using System.Text;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            var attacked = new List<string>();
            var destroyed = new List<string>();
            var rx = new Regex(@"@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<pop>\d+)[^@\-!:>]*!(?<type>[AD])![^@\-!:>]*->(?<soldiers>\d+)");

            for (int i = 0; i < n; i++)
            {
                string enc = Console.ReadLine()!;
                int key = 0;
                foreach (char c in enc)
                {
                    char lc = char.ToLowerInvariant(c);
                    if (lc == 's' || lc == 't' || lc == 'a' || lc == 'r') key++;
                }

                var sb = new StringBuilder(enc.Length);
                foreach (char c in enc) sb.Append((char)(c - key));
                string dec = sb.ToString();

                var m = rx.Match(dec);
                if (!m.Success) continue;

                string name = m.Groups["name"].Value;
                char type = m.Groups["type"].Value[0];

                if (type == 'A') attacked.Add(name);
                else destroyed.Add(name);
            }

            attacked.Sort(StringComparer.Ordinal);
            destroyed.Sort(StringComparer.Ordinal);

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var p in attacked) Console.WriteLine($"-> {p}");
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var p in destroyed) Console.WriteLine($"-> {p}");
        }
    }
}

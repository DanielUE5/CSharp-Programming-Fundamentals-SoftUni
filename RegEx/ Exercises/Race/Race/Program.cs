using System.Text.RegularExpressions;

namespace Race
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var participants = Console.ReadLine()!
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToHashSet();

            var distances = new Dictionary<string, int>();
            string line;
            var letterRx = new Regex("[A-Za-z]");
            var digitRx = new Regex(@"\d");

            while ((line = Console.ReadLine()!) != "end of race")
            {
                var name = string.Concat(letterRx.Matches(line).Select(m => m.Value));
                if (!participants.Contains(name)) continue;

                int distance = digitRx.Matches(line).Sum(m => m.Value[0] - '0');

                if (!distances.ContainsKey(name)) distances[name] = 0;
                distances[name] += distance;
            }

            var top3 = distances
                .OrderByDescending(kv => kv.Value)
                .Take(3)
                .Select(kv => kv.Key)
                .ToList();

            if (top3.Count > 0) Console.WriteLine($"1st place: {top3[0]}");
            if (top3.Count > 1) Console.WriteLine($"2nd place: {top3[1]}");
            if (top3.Count > 2) Console.WriteLine($"3rd place: {top3[2]}");
        }
    }
}

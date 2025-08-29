namespace Count_Real_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>(); // Using SortedDictionary to keep numbers sorted

            foreach (double number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                counts.Add(number, 1);
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}"); // Output each number and its count
            }
        }
    }
}

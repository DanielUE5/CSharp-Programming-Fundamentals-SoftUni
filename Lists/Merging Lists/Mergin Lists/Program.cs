namespace Merging_Lists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> row1 = Console.ReadLine()!
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> row2 = Console.ReadLine()!
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> merged = new List<int>();

            int minLength = Math.Min(row1.Count, row2.Count); // Find the length of the shorter list

            for (int i = 0; i < minLength; i++) // Iterate up to the length of the shorter list
            {
                merged.Add(row1[i]);
                merged.Add(row2[i]);
            }

            if (row1.Count > minLength) // If row1 is longer, add the remaining elements
            {
                merged.AddRange(row1.GetRange(minLength, row1.Count - minLength));
            }
            else if (row2.Count > minLength) // If row2 is longer, add the remaining elements
            {
                merged.AddRange(row2.GetRange(minLength, row2.Count - minLength));
            }
            Console.WriteLine(string.Join(" ", merged));
        }
    }
}

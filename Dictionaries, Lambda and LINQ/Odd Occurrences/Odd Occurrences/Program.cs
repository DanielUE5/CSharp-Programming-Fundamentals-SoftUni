namespace Odd_Occurrences
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!occurrences.ContainsKey(word)) // If the word is not already in the dictionary, add it with an initial count of 0
                {
                    occurrences[word] = 0;
                }
                occurrences[word]++;
            }

            List<string> oddOccurrences = new List<string>(); // List to store words with odd occurrences

            foreach (var oddWords in occurrences)
            {
                if (oddWords.Value % 2 != 0) // Check if the occurrence count is odd
                {
                    oddOccurrences.Add(oddWords.Key);
                }
            }

            Console.WriteLine(string.Join(" ", oddOccurrences));
        }
    }
}

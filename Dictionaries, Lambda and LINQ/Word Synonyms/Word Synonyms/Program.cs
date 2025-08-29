namespace Word_Synonyms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine()!);
            var words = new Dictionary<string, List<string>>(); // Dictionary to hold words and their synonyms

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine()!;
                string synonym = Console.ReadLine()!;
                if (!words.ContainsKey(word)) // Check if the word is already in the dictionary
                {
                    words[word] = new List<string>(); // If not, initialize a new list for synonyms
                }
                words[word].Add(synonym); // Add the synonym to the list
            }

            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}

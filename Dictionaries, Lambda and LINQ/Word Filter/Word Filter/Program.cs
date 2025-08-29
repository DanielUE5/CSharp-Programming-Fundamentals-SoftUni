namespace Word_Filter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] wordsToFilter = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0) // Filter words with even length
                .ToArray(); // Convert the result to an array

            Console.WriteLine(string.Join(Environment.NewLine, wordsToFilter)); // Print each word on a new line
        }
    }
}

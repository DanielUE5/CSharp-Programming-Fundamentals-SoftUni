class VowelsCount
{
    static void Main()
    {
        string word = Console.ReadLine();

        int count = CountVowels(word);
        Console.WriteLine(count);
    }

    static int CountVowels(string word)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";

        foreach (char c in word)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}

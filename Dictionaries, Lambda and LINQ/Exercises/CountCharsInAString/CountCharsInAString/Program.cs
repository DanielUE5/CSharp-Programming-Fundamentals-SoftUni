class CountCharsInAString
{
    static void Main()
    {
        string input = Console.ReadLine();

        CountChars(input);
    }

    static void CountChars(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (c != ' ') 
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
        }

        foreach (KeyValuePair<char, int> entry in charCount)
        {
            Console.WriteLine($"{entry.Key} -> {entry.Value}");
        }
    }
}
 
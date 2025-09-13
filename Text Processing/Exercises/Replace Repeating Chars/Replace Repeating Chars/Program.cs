using System.Text;
class RepeatingChars
{
    static void Main()
    {
        string input = Console.ReadLine().Trim();
        string result = ReplaceRepeatingChars(input);

        Console.WriteLine(result);
    }

    static string ReplaceRepeatingChars(string input)
    {
        StringBuilder result = new StringBuilder();
        char previousChar = input[0]; 
        result.Append(previousChar);

        for (int i = 1; i < input.Length; i++)
        {
            char currentChar = input[i];
            if (currentChar != previousChar)
            {
                result.Append(currentChar);
                previousChar = currentChar; 
            }
        }

        return result.ToString();
    }
}

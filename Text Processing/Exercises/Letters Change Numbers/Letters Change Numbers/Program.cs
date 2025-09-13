class LettersChangeNumber
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] segments = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        decimal totalSum = 0m;

        foreach (string segment in segments)
        {
            int numberStartIndex = 1; 
            while (numberStartIndex < segment.Length && !char.IsDigit(segment[numberStartIndex]))
            {
                numberStartIndex++;
            }

            char letterBefore = segment[0];
            int numberEndIndex = numberStartIndex;
            while (numberEndIndex < segment.Length && char.IsDigit(segment[numberEndIndex]))
            {
                numberEndIndex++;
            }
            decimal number = decimal.Parse(segment.Substring(numberStartIndex, numberEndIndex - numberStartIndex));
            char letterAfter = segment[numberEndIndex];

            int posBefore = char.ToLower(letterBefore) - 'a' + 1;
            int posAfter = char.ToLower(letterAfter) - 'a' + 1;

            if (char.IsUpper(letterBefore))
            {
                number /= posBefore;
            }
            else
            {
                number *= posBefore;
            }

            if (char.IsUpper(letterAfter))
            {
                number -= posAfter;
            }
            else
            {
                number += posAfter;
            }

            totalSum += number;
        }

        Console.WriteLine($"{totalSum:F2}");
    }
}

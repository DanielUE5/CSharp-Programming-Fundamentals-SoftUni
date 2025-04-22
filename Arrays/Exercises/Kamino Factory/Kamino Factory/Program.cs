class KaminoFactory
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        string input;
        int bestLength = -1;
        int bestStartIndex = length;
        int bestSum = -1;
        int[] bestSequence = null;
        int bestSequenceIndex = -1;
        int currentSequenceIndex = 0;

        while ((input = Console.ReadLine()) != "Clone them!")
        {
            currentSequenceIndex++;
            int[] dnaSequence = input.Split(new char[] { '!', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

            int maxOnesLength = 0;
            int currentOnesLength = 0;
            int currentStartIndex = 0;
            int currentSum = dnaSequence.Sum();

            for (int i = 0; i < dnaSequence.Length; i++)
            {
                if (dnaSequence[i] == 1)
                {
                    currentOnesLength++;
                }
                else
                {
                    if (currentOnesLength > maxOnesLength)
                    {
                        maxOnesLength = currentOnesLength;
                        currentStartIndex = i - currentOnesLength;
                    }
                    currentOnesLength = 0;
                }
            }

            if (currentOnesLength > maxOnesLength)
            {
                maxOnesLength = currentOnesLength;
                currentStartIndex = dnaSequence.Length - currentOnesLength;
            }

            if (maxOnesLength > bestLength ||
                (maxOnesLength == bestLength && currentStartIndex < bestStartIndex) ||
                (maxOnesLength == bestLength && currentStartIndex == bestStartIndex && currentSum > bestSum))
            {
                bestLength = maxOnesLength;
                bestStartIndex = currentStartIndex;
                bestSum = currentSum;
                bestSequence = dnaSequence;
                bestSequenceIndex = currentSequenceIndex;
            }
        }

        Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
        Console.WriteLine(string.Join(" ", bestSequence));
    }
}

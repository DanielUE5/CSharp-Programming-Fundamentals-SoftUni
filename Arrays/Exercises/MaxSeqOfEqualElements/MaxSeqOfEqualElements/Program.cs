class MaxSeqOfEqualElemtns
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = array.Length;

        int maxLength = 0;
        int maxLengthElement = array[0];
        int currentLength = 1;
        int currentElement = array[0];

        for (int i = 1; i < n; i++)
        {
            if (array[i] == currentElement)
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxLengthElement = currentElement;
                }
                currentElement = array[i];
                currentLength = 1;
            }
        }

        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxLengthElement = currentElement;
        }

        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(maxLengthElement);
            if (i < maxLength - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
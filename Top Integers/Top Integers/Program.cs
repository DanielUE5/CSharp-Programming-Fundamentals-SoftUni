class TopIntegers
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int n = array.Length;
        int[] topIntegers = new int[n];
        int topCount = 0;

        int maxFromRight = int.MinValue;
        for (int i = n - 1; i >= 0; i--)
        {
            if (array[i] > maxFromRight)
            {
                topIntegers[topCount] = array[i];
                topCount++;
                maxFromRight = array[i];
            }
        }

        for (int i = topCount - 1; i >= 0; i--)
        {
            Console.Write(topIntegers[i]);
            if (i > 0)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

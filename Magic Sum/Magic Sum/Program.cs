class MagicSum
{
    static void Main()
    {
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int target = int.Parse(Console.ReadLine().Trim());
        FindAndPrintPairs(array, target);
    }

    static void FindAndPrintPairs(int[] array, int target)
    {

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == target)
                {
                    Console.WriteLine(array[i] + " " + array[j]);
                }
            }
        }
    }
}

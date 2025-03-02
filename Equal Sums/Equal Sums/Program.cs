class EqualSums
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = array.Length;

        int totalSum = array.Sum();
        int leftSum = 0;

        for (int i = 0; i < n; i++)
        {
            int rightSum = totalSum - leftSum - array[i];

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                return;
            }

            leftSum += array[i];
        }

        Console.WriteLine("no");
    }
}

class ZigZagArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array1 = new int[n];
        int[] array2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int first = int.Parse(input[0]);
            int second = int.Parse(input[1]);

            if (i % 2 == 0)
            {
                array1[i] = first;
                array2[i] = second;
            }
            else
            {
                array1[i] = second;
                array2[i] = first;
            }
        }

        Console.WriteLine(string.Join(" ", array1));
        Console.WriteLine(string.Join(" ", array2));
    }
}

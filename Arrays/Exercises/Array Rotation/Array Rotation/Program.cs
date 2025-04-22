class ArrayRotation
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int rotation = int.Parse(Console.ReadLine());

        rotation %= arr.Length;

        if (rotation != 0)
        {
            int[] rotatedArray = new int[arr.Length];
            Array.Copy(arr, rotation, rotatedArray, 0, arr.Length - rotation);
            Array.Copy(arr, 0, rotatedArray, arr.Length - rotation, rotation);
            arr = rotatedArray;
        }

        Console.WriteLine(string.Join(" ", arr));
    }
}

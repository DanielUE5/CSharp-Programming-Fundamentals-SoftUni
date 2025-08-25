class AppendArrays
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] arrays = input.Split('|').Select(arr => arr.Trim()).Reverse().ToArray();

        List<int> result = new List<int>();

        foreach (string array in arrays)
        {
            int[] numbers = array.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                  .Select(int.Parse)
                                  .ToArray();

            result.AddRange(numbers);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
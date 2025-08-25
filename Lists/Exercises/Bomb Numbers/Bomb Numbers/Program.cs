class BombDetonation
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

        string[] bombInfo = Console.ReadLine().Split();
        int bombNumber = int.Parse(bombInfo[0]);
        int bombPower = int.Parse(bombInfo[1]);

        int index = 0;
        while (index < numbers.Count)
        {
            if (numbers[index] == bombNumber)
            {
                int startIndex = Math.Max(0, index - bombPower);
                int endIndex = Math.Min(numbers.Count - 1, index + bombPower);

                numbers.RemoveRange(startIndex, endIndex - startIndex + 1);

                index = Math.Max(0, startIndex - 1);
            }
            else
            {
                index++;
            }
        }

        int remainingSum = numbers.Sum();
        Console.WriteLine(remainingSum);
    }
}

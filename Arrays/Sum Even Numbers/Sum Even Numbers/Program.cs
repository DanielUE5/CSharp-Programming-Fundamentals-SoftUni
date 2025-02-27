class SumEvenNumbers 
{
    static void Main()
    {
        var numbers = Console.ReadLine();
        int sum = 0;

        int[] arr = numbers.Split(' ').Select(int.Parse).ToArray();

        for(int i = 0; i < arr.Length; i++)
        {
            int currentNumber = arr[i];

            if (currentNumber % 2 == 0)
            {
                sum += currentNumber;
            }
        }
        Console.WriteLine(sum);
    }
}
class SumDigits
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        int sumOfDigits = 0;
        int num = inputNumber;

        while (num > 0)
        {
            sumOfDigits += num % 10;
            num /= 10;
        }

        Console.WriteLine(sumOfDigits);
    }
}

class TopNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int number = 1; number <= n; number++)
        {
            if (IsTopNumber(number))
            {
                Console.WriteLine(number);
            }
        }
    }
    static bool IsTopNumber(int number)
    {
        int sumOfDigits = 0;
        int originalNumber = number;

        while (number > 0)
        {
            int digit = number % 10;
            sumOfDigits += digit;
            number /= 10;
        }

        if (sumOfDigits % 8 != 0)
        {
            return false;
        }

        number = originalNumber;
        bool hasOddDigit = false;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                hasOddDigit = true;
                break;
            }
            number /= 10;
        }

        return hasOddDigit;
    }
}

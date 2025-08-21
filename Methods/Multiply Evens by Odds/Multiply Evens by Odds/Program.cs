namespace Multiply_Evens_by_Odds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                number = Math.Abs(number); // Convert negative to positive
            }
            int result = GetMultiplyEvensByOdds(number);
            Console.WriteLine(result);
        }

        private static int GetMultiplyEvensByOdds(int number)
        {
        int evenSum = GetSumOfEvenDigits(number);
        int oddSum = GetSumOfOddDigits(number);
        return evenSum * oddSum;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}


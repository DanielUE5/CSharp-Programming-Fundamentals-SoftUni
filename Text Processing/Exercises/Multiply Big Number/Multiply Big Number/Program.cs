class MultiplyBigNumber
{
    static void Main()
    {
        string largeNumberStr = Console.ReadLine().Trim();
        int singleDigit = int.Parse(Console.ReadLine().Trim());

        string result = MultiplyLargeNumber(largeNumberStr, singleDigit);

        Console.WriteLine(result);
    }

    static string MultiplyLargeNumber(string numberStr, int multiplier)
    {
        if (multiplier == 0) return "0";

        List<int> result = new List<int>();
        int carry = 0;

        for (int i = numberStr.Length - 1; i >= 0; i--)
        {
            char digitChar = numberStr[i];
            int digit = digitChar - '0'; 
            int product = digit * multiplier + carry;
            carry = product / 10;
            result.Add(product % 10); 
        }

        while (carry > 0)
        {
            result.Add(carry % 10);
            carry /= 10;
        }

        result.Reverse();
        return string.Join("", result);
    }
}

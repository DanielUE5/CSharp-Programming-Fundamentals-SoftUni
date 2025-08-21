class PalindromeIntegers
{
    static void Main()
    {
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            int number = int.Parse(input);
            bool isPalindrome = IsPalindrome(number);
            Console.WriteLine(isPalindrome.ToString().ToLower()); 
        }
    }

    static bool IsPalindrome(int number)
    {
        string numStr = number.ToString();
        int left = 0;
        int right = numStr.Length - 1;

        while (left < right)
        {
            if (numStr[left] != numStr[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}

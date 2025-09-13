class Character_Multiplier
{
    static void Main()
    {

        string input = Console.ReadLine();

        var parts = input.Split(new[] { ' ' }, 2);
        if (parts.Length != 2)
        {
            Console.WriteLine("Invalid input. Please provide exactly two strings separated by a space.");
            return;
        }

        string str1 = parts[0];
        string str2 = parts[1];

        int result = CharacterMultiplier(str1, str2);
        Console.WriteLine(result);
    }

    static int CharacterMultiplier(string str1, string str2)
    {
        int sum = 0;
        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            sum += str1[i] * str2[i];
        }

        if (str1.Length > str2.Length)
        {
            for (int i = minLength; i < str1.Length; i++)
            {
                sum += str1[i];
            }
        }
        else if (str2.Length > str1.Length)
        {
            for (int i = minLength; i < str2.Length; i++)
            {
                sum += str2[i];
            }
        }

        return sum;
    }
}

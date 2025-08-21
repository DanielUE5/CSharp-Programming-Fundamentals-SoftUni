class  PasswordValidator
{
static void Main()
    {
        string password = Console.ReadLine();

        bool isLengthValid = IsPasswordLengthValid(password);
        bool isCharTypeValid = IsPasswordCharacterTypeValid(password);
        bool isDigitCountValid = HasMinimumDigitCount(password);

        if (isLengthValid && isCharTypeValid && isDigitCountValid)
        {
            Console.WriteLine("Password is valid");
        }
    }

static bool IsPasswordLengthValid(string password)
    {
        if (password.Length < 6 || password.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            return false;
        }
        return true;
    }

static bool IsPasswordCharacterTypeValid(string password)
    {
        if (!password.All(char.IsLetterOrDigit))
        {
            Console.WriteLine("Password must consist only of letters and digits");
            return false;
        }
        return true;
    }

static bool HasMinimumDigitCount(string password)
    {
        int digitCount = password.Count(char.IsDigit);
        if (digitCount < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            return false;
        }
        return true;
    }
}

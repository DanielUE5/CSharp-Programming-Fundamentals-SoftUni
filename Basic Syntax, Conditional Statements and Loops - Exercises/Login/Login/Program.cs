class Login
{
    static void Main()
    {
        string username = Console.ReadLine();
        string password = ReverseString(username);
        int count = 0;

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        while (true)
        {
            string inputPass = Console.ReadLine();
            count++;

            if (inputPass == password)
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
            else if (count == 4)
            {
                Console.WriteLine($"User {username} blocked!");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }    
}

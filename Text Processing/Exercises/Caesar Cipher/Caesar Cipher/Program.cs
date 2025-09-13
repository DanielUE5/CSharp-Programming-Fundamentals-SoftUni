class CaesarCipher
{
    static void Main()
    {
        string input = Console.ReadLine();

        string encryptedText = EncryptText(input);
        Console.WriteLine(encryptedText);
    }

    static string EncryptText(string text)
    {
        char[] buffer = text.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char c = buffer[i];

            buffer[i] = (char)(c + 3);
        }
        return new string(buffer);
    }
}

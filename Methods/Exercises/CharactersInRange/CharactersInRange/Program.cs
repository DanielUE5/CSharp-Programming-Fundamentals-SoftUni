class CharInRange
{
static void Main()
    {
        char char1 = Console.ReadLine()[0]; 
        char char2 = Console.ReadLine()[0];

        CharactersInRange(char1, char2);
    }

static void CharactersInRange(char char1, char char2)
    {
        char start = (char)Math.Min(char1, char2);
        char end = (char)Math.Max(char1, char2);

        for (int asciiValue = start + 1; asciiValue < end; asciiValue++)
        {
            Console.Write((char)asciiValue + " ");
        }
        Console.WriteLine();
    }
}

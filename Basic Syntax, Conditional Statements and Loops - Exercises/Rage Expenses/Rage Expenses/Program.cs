class Rage_Expenses
{
    static void Main()
    {
        int lostGamesCount = int.Parse(Console.ReadLine());
        float headsetPrice = float.Parse(Console.ReadLine());
        float mousePrice = float.Parse(Console.ReadLine());
        float keyboardPrice = float.Parse(Console.ReadLine());
        float displayPrice = float.Parse(Console.ReadLine());

        int headsetsTrashed = 0;
        int miceTrashed = 0;
        int keyboardsTrashed = 0;
        int displaysTrashed = 0;

        for (int game = 1; game <= lostGamesCount; game++)
        {
            bool headsetTrashed = false;
            bool mouseTrashed = false;

            if (game % 2 == 0)
            {
                headsetsTrashed++;
                headsetTrashed = true;
            }

            if (game % 3 == 0)
            {
                miceTrashed++;
                mouseTrashed = true;
            }

            if (headsetTrashed && mouseTrashed)
            {
                keyboardsTrashed++;

                if (keyboardsTrashed % 2 == 0)
                {
                    displaysTrashed++;
                }
            }
        }
        double totalExpenses = (headsetsTrashed * headsetPrice) +
                               (miceTrashed * mousePrice) +
                               (keyboardsTrashed * keyboardPrice) +
                               (displaysTrashed * displayPrice);
        Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
    }
}
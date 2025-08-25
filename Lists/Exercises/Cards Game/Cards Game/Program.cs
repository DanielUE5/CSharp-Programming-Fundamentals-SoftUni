class CardsGame
{
    static void Main()
    {
        List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
        {
            int firstCard = firstPlayer[0];
            int secondCard = secondPlayer[0];

            firstPlayer.RemoveAt(0);
            secondPlayer.RemoveAt(0);

            if (firstCard > secondCard)
            {
                firstPlayer.Add(secondCard);
                firstPlayer.Add(firstCard);
            }
            else if (secondCard > firstCard)
            {
                secondPlayer.Add(firstCard);
                secondPlayer.Add(secondCard);
            }
        }

        if (firstPlayer.Count == 0)
        {
            int sum = secondPlayer.Sum();
            Console.WriteLine($"Second player wins! Sum: {sum}");
        }
        else if (secondPlayer.Count == 0)
        {
            int sum = firstPlayer.Sum();
            Console.WriteLine($"First player wins! Sum: {sum}");
        }
    }
}

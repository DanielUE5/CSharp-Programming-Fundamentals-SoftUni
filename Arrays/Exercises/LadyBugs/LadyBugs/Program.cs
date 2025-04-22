class LadyBugs
{
    static void Main(string[] args)
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] field = new int[fieldSize];
        int[] ladybugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        foreach (int index in ladybugIndexes)
        {
            if (index >= 0 && index < fieldSize)
            {
                field[index] = 1;
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] commandParts = command.Split();
            int ladybugIndex = int.Parse(commandParts[0]);
            string direction = commandParts[1];
            int flyLength = int.Parse(commandParts[2]);

            if (ladybugIndex < 0 || ladybugIndex >= fieldSize || field[ladybugIndex] != 1)
            {
                continue;
            }

            field[ladybugIndex] = 0;

            while (true)
            {
                if (direction == "right")
                {
                    ladybugIndex += flyLength;
                }
                else if (direction == "left")
                {
                    ladybugIndex -= flyLength;
                }

                if (ladybugIndex < 0 || ladybugIndex >= fieldSize)
                {
                    break;
                }

                if (field[ladybugIndex] == 0)
                {
                    field[ladybugIndex] = 1;
                    break;
                }
            }
        }

        Console.WriteLine(string.Join(" ", field));
    }
}

class Train
{
    static void Main()
    {
        List<int> passangers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int maxCapacity = int.Parse(Console.ReadLine());

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] arguments = input.Split();

            if (arguments[0] == "Add")
            {
                passangers.Add(int.Parse(arguments[1]));
            }
            else
            {
                int newPassangers = int.Parse(arguments[0]);
                for (int i = 0; i < passangers.Count; i++)
                {
                    if (passangers[i] + newPassangers <= maxCapacity)
                    {
                        passangers[i] += newPassangers;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" ", passangers));
    }
}
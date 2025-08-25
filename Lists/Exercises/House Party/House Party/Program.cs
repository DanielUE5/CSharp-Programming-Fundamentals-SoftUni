class HouseParty
{
    static void Main()
    {
        int numCommands = int.Parse(Console.ReadLine());

        List<string> guestList = new List<string>();

        for (int i = 0; i < numCommands; i++)
        {
            string command = Console.ReadLine();

            string[] parts = command.Split();
            string name = parts[0];

            if (parts[1] == "is" && parts[2] == "going!")
            {
                if (guestList.Contains(name))
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else
                {
                    guestList.Add(name);
                }
            }
            else if (parts[2] == "not")
            {
                if (guestList.Contains(name))
                {
                    guestList.Remove(name);
                }
                else
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
        }

        foreach (string guest in guestList)
        {
            Console.WriteLine(guest);
        }
    }
}

class SoftUniParking
{
    static void Main()
    {
        Dictionary<string, string> parkingLot = new Dictionary<string, string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] commandParts = Console.ReadLine().Split();

            string action = commandParts[0];
            string username = commandParts[1];

            if (action == "register")
            {
                string licensePlateNumber = commandParts[2];

                if (parkingLot.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {parkingLot[username]}");
                }
                else
                {
                    parkingLot[username] = licensePlateNumber;
                    Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                }
            }
            else if (action == "unregister")
            {
                if (!parkingLot.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
                else
                {
                    parkingLot.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
            }
        }

        foreach (var user in parkingLot)
        {
            Console.WriteLine($"{user.Key} => {user.Value}");
        }
    }
}

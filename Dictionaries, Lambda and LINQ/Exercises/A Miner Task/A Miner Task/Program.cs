class AMinerTask
{
    static void Main()
    {
        Dictionary<string, long> resources = new Dictionary<string, long>();

        while (true)
        {
            string resource = Console.ReadLine();

            if (resource.ToLower() == "stop")
            {
                break;
            }

            long quantity = long.Parse(Console.ReadLine());

            if (resources.ContainsKey(resource))
            {
                resources[resource] += quantity;
            }
            else
            {
                resources[resource] = quantity;
            }
        }

        foreach (var kvp in resources)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}

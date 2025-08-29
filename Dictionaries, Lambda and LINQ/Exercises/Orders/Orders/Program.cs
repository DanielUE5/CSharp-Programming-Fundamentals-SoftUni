using System.Globalization;
class Orders
{
    static void Main()
    {
        Dictionary<string, (decimal Price, int Quantity)> products = new Dictionary<string, (decimal Price, int Quantity)>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "buy")
            {
                break;
            }

            string[] parts = input.Split(' ');

            string name = parts[0];
            decimal price = decimal.Parse(parts[1], CultureInfo.InvariantCulture);
            int quantity = int.Parse(parts[2]);

            if (products.ContainsKey(name))
            {
                products[name] = (price, products[name].Quantity + quantity);
            }
            else
            {
                products[name] = (price, quantity);
            }
        }

        foreach (var kvp in products)
        {
            string productName = kvp.Key;
            decimal totalPrice = kvp.Value.Price * kvp.Value.Quantity;
            Console.WriteLine($"{productName} -> {totalPrice:F2}");
        }
    }
}

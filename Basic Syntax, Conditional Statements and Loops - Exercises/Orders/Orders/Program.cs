class Orders
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double totalOrderPrice = 0;

        for (int i = 0; i < N; i++)
        {
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());

            double orderPrice = days * capsulesCount * pricePerCapsule;

            Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");

            totalOrderPrice += orderPrice;
        }
        Console.WriteLine($"Total: ${totalOrderPrice:F2}");
    }
}

class PadawanEquipment
{
    static void Main()
    {
        double amountOfMoney = double.Parse(Console.ReadLine());
        int numStudents = int.Parse(Console.ReadLine());
        double priceLightsaber = double.Parse(Console.ReadLine());
        double priceRobe = double.Parse(Console.ReadLine());
        double priceBelt = double.Parse(Console.ReadLine());

        int lightsabersNeeded = (int)Math.Ceiling(numStudents * 1.10);
        double totalCostLightsabers = lightsabersNeeded * priceLightsaber;

        double totalCostRobes = numStudents * priceRobe;

        int freeBelts = numStudents / 6;
        int beltsNeeded = numStudents - freeBelts;
        double totalCostBelts = beltsNeeded * priceBelt;

        double totalCost = totalCostLightsabers + totalCostRobes + totalCostBelts;

        if (totalCost <= amountOfMoney)
        {
            Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
        }
        else
        {
            double neededMoney = totalCost - amountOfMoney;
            Console.WriteLine($"John will need {neededMoney:F2}lv more.");
        }
    }
}

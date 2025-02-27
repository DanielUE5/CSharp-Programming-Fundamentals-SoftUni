class BeerKegs {
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string largestKegModel = "";
        double largestVolume = 0;

        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;

            if (volume > largestVolume)
            {
                largestVolume = volume;
                largestKegModel = model;
            }
        }
        Console.WriteLine(largestKegModel);
    }
}

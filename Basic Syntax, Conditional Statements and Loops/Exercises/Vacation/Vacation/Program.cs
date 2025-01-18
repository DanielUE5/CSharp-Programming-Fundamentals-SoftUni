class Vacation
{
    static void Main()
    {
        int countOfPeople = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string day = Console.ReadLine();
        double pricePerPerson = 0.0;

        if (day == "Friday")
        {
            if (groupType == "Students")
            {
                pricePerPerson = 8.45;
            }
            else if (groupType == "Business")
            {
                pricePerPerson = 10.90;
            }
            else 
            {
                pricePerPerson = 15.00;
            }
        }
        else if (day == "Saturday")
        {
            if (groupType == "Students")
            {
                pricePerPerson = 9.80;
            }
            else if (groupType == "Business")
            {
                pricePerPerson = 15.60;
            }
            else 
            {
                pricePerPerson = 20.00;
            }
        }
        else if (day == "Sunday")
        {
            if (groupType == "Students")
            {
                pricePerPerson = 10.46;
            }
            else if (groupType == "Business")
            {
                pricePerPerson = 16.00;
            }
            else 
            {
                pricePerPerson = 22.50;
            }
        }

        double totalPrice = countOfPeople * pricePerPerson;

        if (groupType == "Students" && countOfPeople >= 30)
        {
            totalPrice *= 0.85; 
        }
        else if (groupType == "Business" && countOfPeople >= 100)
        {
            totalPrice = (countOfPeople - 10) * pricePerPerson; 
        }
        else if (groupType == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
        {
            totalPrice *= 0.95; 
        }

        Console.WriteLine($"Total price: {totalPrice:F2}");
    }
}

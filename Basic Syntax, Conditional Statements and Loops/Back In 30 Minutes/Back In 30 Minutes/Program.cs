class Back_In_30_Minutes
{
    static void Main()
    {
        int first_number = int.Parse(Console.ReadLine());
        int second_number = int.Parse(Console.ReadLine());

        second_number += 30;

        if (second_number > 59)
        {
            first_number += 1;
            second_number -= 60;
        }

        if (first_number > 23)
        {
            first_number -= 24;
        }

        if (second_number < 10)
        {
            Console.WriteLine($"{first_number}:0{second_number}");
        }
        else
        {
            Console.WriteLine($"{first_number}:{second_number}");
        }
    }
}



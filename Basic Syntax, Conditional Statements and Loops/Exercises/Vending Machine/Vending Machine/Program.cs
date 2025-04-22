class Vending_Machine
{
    static void Main()
    {
        double balance = 0.0;

        string input;
        while ((input = Console.ReadLine()) != "Start")
        {
            double coin = double.Parse(input);

            if (coin == 0.1 ||
                coin == 0.2 ||
                coin == 0.5 ||
                coin == 1 ||
                coin == 2)
            {
                balance += coin;
            }
            else
            {
                Console.WriteLine($"Cannot accept {coin}");
            }
        }
            while ((input = Console.ReadLine()) != "End") 
                {
                switch (input)
                {
                    case "Nuts":
                        if (balance >= 2)
                        {
                            balance -= 2;
                            Console.WriteLine("Purchased nuts");
                        } 
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                        break;
                    case "Water":
                        if (balance >= 0.7)
                        {
                            balance -= 0.7;
                            Console.WriteLine("Purchased water");
                        }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                    case "Crisps":
                        if (balance >= 1.5)
                        {
                            balance -= 1.5;
                            Console.WriteLine("Purchased crisps");
                        }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                    case "Soda":
                        if (balance >= 0.8)
                        {
                            balance -= 0.8;
                            Console.WriteLine("Purchased soda");
                        }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                    case "Coke":
                        if (balance >= 1)
                        {
                            balance -= 1;
                            Console.WriteLine("Purchased coke");
                        }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
            Console.WriteLine($"Change: {balance:F2}");
        }
    }


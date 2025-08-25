using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        bool isChanged = false;

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] tokens = command.Split();
            string action = tokens[0];

            switch (action)
            {
                case "Add":
                    numbers.Add(int.Parse(tokens[1]));
                    isChanged = true;
                    break;

                case "Remove":
                    numbers.Remove(int.Parse(tokens[1]));
                    isChanged = true;
                    break;

                case "RemoveAt":
                    numbers.RemoveAt(int.Parse(tokens[1]));
                    isChanged = true;
                    break;

                case "Insert":
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, number);
                    isChanged = true;
                    break;

                case "Contains":
                    int element = int.Parse(tokens[1]);
                    if (numbers.Contains(element))
                        Console.WriteLine("Yes");
                    else
                        Console.WriteLine("No such number");
                    break;

                case "PrintEven":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                    break;

                case "PrintOdd":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                    break;

                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;

                case "Filter":
                    string condition = tokens[1];
                    int value = int.Parse(tokens[2]);

                    IEnumerable<int> result = condition switch
                    {
                        "<" => numbers.Where(n => n < value),
                        ">" => numbers.Where(n => n > value),
                        "<=" => numbers.Where(n => n <= value),
                        ">=" => numbers.Where(n => n >= value),
                        _ => Enumerable.Empty<int>()
                    };

                    Console.WriteLine(string.Join(" ", result));
                    break;
            }
        }

        if (isChanged)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

class ListOperations
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split();
            switch (arguments[0])
            {
                case "Add":
                    numbers.Add(int.Parse(arguments[1]));
                    break;

                case "Insert":
                    int number = int.Parse(arguments[1]);
                    int IndexInsert = int.Parse(arguments[2]);

                    if (IndexInsert >= 0 && IndexInsert <= numbers.Count - 1)
                    {
                        numbers.Insert(IndexInsert, number);
                    } else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    break;

                case "Remove":
                    int removeIndex = int.Parse(arguments[1]);
                    if (removeIndex >= 0 && removeIndex <= numbers.Count - 1) 
                    {
                        numbers.RemoveAt(removeIndex);
                    } else
                    {
                        Console.WriteLine("Invalid index");
                    }

                    break;

                case "Shift":
                    int count = int.Parse(arguments[2]);
                    count %= numbers.Count;

                    switch (arguments[1])
                    {
                        case "left":
                            List<int> shiftedPart = numbers.GetRange(0, count);
                            numbers.RemoveRange(0, count);
                            numbers.InsertRange(numbers.Count, shiftedPart);
                            break;
                        case "right":
                            shiftedPart = numbers.GetRange(numbers.Count - count, count);
                            numbers.RemoveRange(numbers.Count - count, count);
                            numbers.InsertRange(0, shiftedPart);
                            break;
                    }
                    break;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
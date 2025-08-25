class ChangeList
{
    static void Main()
    {
        List<int> list = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToList();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] arguments = command.Split();
            switch (arguments[0])
            {
                case "Delete":
                    int deleteNumber = int.Parse(arguments[1]);
                        list.RemoveAll(x => x == deleteNumber);

                        break;

                case "Insert":
                    int number = int.Parse(arguments[1]);
                    int IndexInsert = int.Parse(arguments[2]);
                    list.Insert(IndexInsert, number);

                    break;
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }
}
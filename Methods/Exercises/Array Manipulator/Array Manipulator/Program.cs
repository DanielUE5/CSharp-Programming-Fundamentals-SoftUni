using System;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] commandParts = command.Split();
            string operation = commandParts[0];

            if (operation == "exchange")
            {
                int index = int.Parse(commandParts[1]);
                array = Exchange(array, index);
            }
            else if (operation == "max")
            {
                string type = commandParts[1];
                int index = FindMaxIndex(array, type);
                PrintIndex(index);
            }
            else if (operation == "min")
            {
                string type = commandParts[1];
                int index = FindMinIndex(array, type);
                PrintIndex(index);
            }
            else if (operation == "first")
            {
                int count = int.Parse(commandParts[1]);
                string type = commandParts[2];
                PrintFirstElements(array, count, type);
            }
            else if (operation == "last")
            {
                int count = int.Parse(commandParts[1]);
                string type = commandParts[2];
                PrintLastElements(array, count, type);
            }
        }

        Console.WriteLine($"[{string.Join(", ", array)}]");
    }

    static int[] Exchange(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Invalid index");
            return array;
        }

        int[] firstPart = array.Take(index + 1).ToArray();
        int[] secondPart = array.Skip(index + 1).ToArray();
        int[] exchangedArray = secondPart.Concat(firstPart).ToArray();

        return exchangedArray;
    }

    static int FindMaxIndex(int[] array, string type)
    {
        bool isEven = type == "even";
        int maxNumber = int.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] % 2 == 0 && isEven) || (array[i] % 2 != 0 && !isEven))
            {
                if (array[i] >= maxNumber)
                {
                    maxNumber = array[i];
                    maxIndex = i;
                }
            }
        }

        if (maxIndex == -1)
        {
            Console.WriteLine("No matches");
        }

        return maxIndex;
    }

    static int FindMinIndex(int[] array, string type)
    {
        bool isEven = type == "even";
        int minNumber = int.MaxValue;
        int minIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] % 2 == 0 && isEven) || (array[i] % 2 != 0 && !isEven))
            {
                if (array[i] <= minNumber)
                {
                    minNumber = array[i];
                    minIndex = i;
                }
            }
        }

        if (minIndex == -1)
        {
            Console.WriteLine("No matches");
        }

        return minIndex;
    }

    static void PrintIndex(int index)
    {
        if (index != -1)
        {
            Console.WriteLine(index);
        }
    }

    public static void PrintFirstElements(int[] array, int count, string type)
    {
        if (count > array.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        bool isEven = type == "even";
        int[] elements = new int[count];
        int elementsCount = 0;

        for (int i = 0; i < array.Length && elementsCount < count; i++)
        {
            if ((array[i] % 2 == 0 && isEven) || (array[i] % 2 != 0 && !isEven))
            {
                elements[elementsCount] = array[i];
                elementsCount++;
            }
        }

        Console.WriteLine($"[{string.Join(", ", elements.Take(elementsCount))}]");
    }

    public static void PrintLastElements(int[] array, int count, string type)
    {
        if (count > array.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        bool isEven = type == "even";
        int[] elements = new int[count];
        int elementsCount = 0;

        for (int i = array.Length - 1; i >= 0 && elementsCount < count; i--)
        {
            if ((array[i] % 2 == 0 && isEven) || (array[i] % 2 != 0 && !isEven))
            {
                elements[elementsCount] = array[i];
                elementsCount++;
            }
        }

        Array.Reverse(elements, 0, elementsCount);
        Console.WriteLine($"[{string.Join(", ", elements.Take(elementsCount))}]");
    }
}

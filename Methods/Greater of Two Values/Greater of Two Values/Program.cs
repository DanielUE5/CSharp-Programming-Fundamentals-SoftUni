using System;

namespace Greater_of_Two_Values
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int aInt = int.Parse(firstValue);
                    int bInt = int.Parse(secondValue);
                    Console.WriteLine(GetGreaterValue(aInt, bInt));
                    break;

                case "char":
                    char aChar = char.Parse(firstValue);
                    char bChar = char.Parse(secondValue);
                    Console.WriteLine(GetGreaterValue(aChar, bChar));
                    break;

                case "string":
                    Console.WriteLine(GetGreaterValue(firstValue, secondValue));
                    break;

                default:
                    Console.WriteLine("Unknown type");
                    break;
            }
        }

        static int GetGreaterValue(int a, int b) => a > b ? a : b;

        static char GetGreaterValue(char a, char b) => a > b ? a : b;

        static string GetGreaterValue(string a, string b) =>
            string.Compare(a, b, StringComparison.Ordinal) >= 0 ? a : b;
    }
}

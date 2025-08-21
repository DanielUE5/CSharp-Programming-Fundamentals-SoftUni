namespace Repeat_String
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            RepeatString(inputString, repeatCount);
        }

            private static string RepeatString(string str, int count)
            {
                string result = string.Empty;
                for (int i = 0; i < count; i++)
                {
                    result += str;
            }
                Console.WriteLine(result);
                return result;
        }
    }
}

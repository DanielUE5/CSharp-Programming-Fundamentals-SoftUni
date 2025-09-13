using System.Text;

namespace Substring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string substr = Console.ReadLine() ?? string.Empty;
            string str = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrEmpty(substr)) // If the substring is empty, print the original string
            {
                Console.WriteLine(str);
                return;
            }

            int index = str.IndexOf(substr); // Find the first occurrence of the substring
            while (index != -1) // While the substring is found in the string
            {
                str = str.Remove(index, substr.Length); // Remove the substring from the string
                index = str.IndexOf(substr); // Find the next occurrence of the substring
            }

            Console.WriteLine(str.Length > 0 ? str : "Substring not found!"); // Print the modified string or a message if it's empty
        }
    }
}

using System.Text;

namespace Text_Filter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            foreach (var banned in bannedWords)
            {
                text = text.Replace(banned, new string('*', banned.Length));
            }
            Console.WriteLine();
            Console.WriteLine(text); 
        }
    }
}
